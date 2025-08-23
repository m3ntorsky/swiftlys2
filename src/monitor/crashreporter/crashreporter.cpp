/************************************************************************************************
 *  SwiftlyS2 is a scripting framework for Source2-based games.
 *  Copyright (C) 2025 Swiftly Solution SRL via Sava Andrei-Sebastian and it's contributors
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 ************************************************************************************************/

#include "crashreporter.h"

#include <api/interfaces/manager.h>
#include <api/shared/texttable.h>
#include <api/shared/string.h>
#include <api/shared/files.h>

#include <public/tier0/icommandline.h>
#include <public/eiface.h>

#ifdef _WIN32
#include <windows.h>
#include <tchar.h>
#include <dbghelp.h>
#else
#include <backtrace.h>
#endif

#include <format>

#ifndef GITHUB_SHA
#define GITHUB_SHA "LOCAL"
#endif
#ifndef SWIFTLY_VERSION
#define SWIFTLY_VERSION "LOCAL"
#endif

std::string startup_cmd;

void WriteCrashDump(std::vector<std::string> functionStack);

#ifdef _WIN32
LONG WINAPI CustomUnhandledExceptionFilter(EXCEPTION_POINTERS* pExceptionPointers)
{
    std::vector<std::string> functionStack;

    HANDLE hProcess = GetCurrentProcess();
    HANDLE hThread = GetCurrentThread();

    SymInitialize(hProcess, NULL, TRUE);

    CONTEXT* context = pExceptionPointers->ContextRecord;

    STACKFRAME64 stackFrame = { 0 };
#ifdef _M_X64
    DWORD machineType = IMAGE_FILE_MACHINE_AMD64;
    stackFrame.AddrPC.Offset = context->Rip;
    stackFrame.AddrPC.Mode = AddrModeFlat;
    stackFrame.AddrFrame.Offset = context->Rbp;
    stackFrame.AddrFrame.Mode = AddrModeFlat;
    stackFrame.AddrStack.Offset = context->Rsp;
    stackFrame.AddrStack.Mode = AddrModeFlat;
#else
#error "Platform not supported!"
#endif

    for (int frame = 0; frame < 64; ++frame)
    {
        if (!StackWalk64(machineType, hProcess, hThread, &stackFrame, context,
            NULL, SymFunctionTableAccess64, SymGetModuleBase64, NULL))
        {
            break;
        }

        DWORD64 address = stackFrame.AddrPC.Offset;
        if (address == 0) break;

        char buffer[sizeof(SYMBOL_INFO) + MAX_SYM_NAME] = {};
        SYMBOL_INFO* symbol = reinterpret_cast<SYMBOL_INFO*>(buffer);
        symbol->SizeOfStruct = sizeof(SYMBOL_INFO);
        symbol->MaxNameLen = MAX_SYM_NAME;

        std::string constructFunctionStr = "";
        DWORD64 displacement = 0;
        if (SymFromAddr(hProcess, address, &displacement, symbol))
        {
            constructFunctionStr += symbol->Name;
        }

        IMAGEHLP_LINE64 line;
        DWORD lineDisplacement = 0;
        memset(&line, 0, sizeof(line));
        line.SizeOfStruct = sizeof(line);

        if (SymGetLineFromAddr64(hProcess, address, &lineDisplacement, &line))
        {
            constructFunctionStr += (std::string(" -> ") + line.FileName + ":" + std::to_string(line.LineNumber - 2));
        }

        if (constructFunctionStr != "") functionStack.push_back(constructFunctionStr);
    }

    SymCleanup(hProcess);

    WriteCrashDump(functionStack);

    return EXCEPTION_EXECUTE_HANDLER;
}
#else
static int full_callback(void* data, uintptr_t pc, const char* filename, int lineno, const char* function) {
    std::vector<std::string>& arr = *reinterpret_cast<std::vector<std::string>*>(data);
    std::string constructFunctionStr = "";
    if (filename && function) {
        constructFunctionStr += std::string(function) + " -> " + filename + ":" + std::to_string(lineno);
    }
    arr.push_back(constructFunctionStr);
    return 0;
}

static void error_callback(void*, const char* msg, int) {
    std::cerr << "libbacktrace error: " << msg << std::endl;
}

void signal_handler(int signum)
{
    std::vector<std::string> functionStack;

    auto state = backtrace_create_state(nullptr, 1, error_callback, nullptr);
    backtrace_full(state, 0, full_callback, error_callback, &functionStack);

    WriteCrashDump(functionStack);
}
#endif

void CrashReporter::Init()
{
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    if (!Files::ExistsPath("addons/swiftly/dumps"))
    {
        if (!Files::CreateDir("addons/swiftly/dumps"))
        {
            logger->Error("Crash Listener", "Couldn't create dumps folder.\n");
            return;
        }
    }

    if (!Files::ExistsPath("addons/swiftly/dumps/prevention"))
    {
        if (!Files::CreateDir("addons/swiftly/dumps/prevention"))
        {
            logger->Error("Crash Listener", "Couldn't create dumps prevention folder.\n");
            return;
        }
    }

    startup_cmd = CommandLine()->GetCmdLine();
    std::vector<std::string> exp = explode(startup_cmd, " ");
    std::vector<std::string> exp2;
    for (std::size_t i = 1; i < exp.size(); i++)
    {
        std::string str = trim(exp[i]);
        if (str.length() == 0)
            continue;
        if (exp2.size() > 0)
            if (ends_with(exp2[exp2.size() - 1], "sv_setsteamaccount") || ends_with(exp2[exp2.size() - 1], "authkey") || ends_with(exp2[exp2.size() - 1], "ip"))
                str = "REDACTED";

        exp2.push_back(str);
    }
    startup_cmd = implode(exp2, " ");

#ifdef _WIN32
    SetUnhandledExceptionFilter(CustomUnhandledExceptionFilter);
#else
    ::signal(SIGSEGV, &signal_handler);
#endif
}

void CrashReporter::Shutdown()
{
#ifdef _WIN32
    SetUnhandledExceptionFilter(NULL);
#else
    ::signal(SIGSEGV, SIG_DFL);
#endif
}

bool crashed = false;

void WriteCrashDump(std::vector<std::string> functionStack)
{
    if (crashed) return;

    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    auto callstack = g_ifaceService.FetchInterface<ICallStack>(CALLSTACK_INTERFACE_VERSION);

    crashed = true;
    logger->Error("Crash Reporter", "A crash has occured and a dump has been created:\n");

    std::string file_path = std::format("addons/swiftly/dumps/crash.{}.log", get_uuid());
    if (Files::ExistsPath(file_path)) Files::Delete(file_path);

    TextTable backtraceTable('-', '|', '+');

    backtraceTable.add(" ID ");
    backtraceTable.add(" Data ");
    backtraceTable.endOfRow();

    for (int i = 0; i < functionStack.size(); i++) {
        backtraceTable.add(std::format(" {:02}. ", i + 1));
        backtraceTable.add(std::format(" {} ", functionStack[i]));
        backtraceTable.endOfRow();

        functionStack[i] = std::format("{:02}. {}", i + 1, functionStack[i]);
    }

    PrintTextTable(LogType::ERR, "Crash Reporter", backtraceTable);

    Files::Append(file_path, std::format("================================\nCommand: {}\nMap: {}\nVersion: {} ({})\n================================\n\n{}\n\n{}", startup_cmd, engine->GetServerGlobals() ? engine->GetServerGlobals()->mapname.ToCStr() : "None", SWIFTLY_VERSION, GITHUB_SHA, implode(functionStack, "\n"), callstack->GetFullCallStack()), false);
    logger->Error("Crash Reporter", std::format("A dump log file has been created at: {}\n", file_path));
    exit(1);
}

void CrashReporter::ReportPreventionIncident(std::string category, std::string reason)
{
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    auto callstack = g_ifaceService.FetchInterface<ICallStack>(CALLSTACK_INTERFACE_VERSION);

    logger->Warning("Crash Prevention", "A crash has been prevented by Swiftly Core and the details will be listed below:\n");

    TextTable backtraceTable('-', '|', '+');

    backtraceTable.add(" Category ");
    backtraceTable.add(" Message ");
    backtraceTable.endOfRow();

    backtraceTable.add(std::format(" {} ", category));
    backtraceTable.add(std::format(" {} ", reason));
    backtraceTable.endOfRow();

    PrintTextTable(LogType::WARNING, "Crash Prevention", backtraceTable);

    std::string file_path = std::format("addons/swiftly/dumps/prevention/incident.%s.log", get_uuid());
    if (Files::ExistsPath(file_path)) Files::Delete(file_path);

    Files::Append(file_path, std::format("================================\nCategory: {}\nDetails: {}\n\n{}", category, reason, callstack->GetFullCallStack()), false);
    logger->Warning("Crash Prevention", std::format("A log file has been created at: {}\n", file_path));
}