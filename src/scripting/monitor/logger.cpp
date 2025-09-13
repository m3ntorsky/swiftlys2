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

#include <scripting/scripting.h>
#include <api/interfaces/manager.h>

void Bridge_Monitor_Logger_Log(int logType, const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Log((LogType)logType, message);
}

void Bridge_Monitor_Logger_LogCategory(int logType, const char* category, const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Log((LogType)logType, category, message);
}

void Bridge_Monitor_Logger_Info(const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Info(message);
}

void Bridge_Monitor_Logger_Warning(const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Warning(message);
}

void Bridge_Monitor_Logger_Error(const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Error(message);
}

void Bridge_Monitor_Logger_Debug(const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Debug(message);
}

void Bridge_Monitor_Logger_InfoCategory(const char* category, const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Info(category, message);
}

void Bridge_Monitor_Logger_WarningCategory(const char* category, const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Warning(category, message);
}

void Bridge_Monitor_Logger_ErrorCategory(const char* category, const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Error(category, message);
}

void Bridge_Monitor_Logger_DebugCategory(const char* category, const char* message) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Debug(category, message);
}

void Bridge_Monitor_Logger_SetLogFile(int logType, const char* path) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->SetLogFile((LogType)logType, path);
}

void Bridge_Monitor_Logger_ShouldOutputToFile(int logType, bool enabled) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->ShouldOutputToFile((LogType)logType, enabled);
}

void Bridge_Monitor_Logger_ShouldColorCategoryInConsole(const char* category, bool enabled) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->ShouldColorCategoryInConsole(category, enabled);
}

void Bridge_Monitor_Logger_ShouldOutputToConsole(int logType, bool enabled) {
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->ShouldOutputToConsole((LogType)logType, enabled);
}

DEFINE_NATIVE("Logger.Log", Bridge_Monitor_Logger_Log);
DEFINE_NATIVE("Logger.LogCategory", Bridge_Monitor_Logger_LogCategory);
DEFINE_NATIVE("Logger.Info", Bridge_Monitor_Logger_Info);
DEFINE_NATIVE("Logger.InfoCategory", Bridge_Monitor_Logger_InfoCategory);
DEFINE_NATIVE("Logger.Warning", Bridge_Monitor_Logger_Warning);
DEFINE_NATIVE("Logger.WarningCategory", Bridge_Monitor_Logger_WarningCategory);
DEFINE_NATIVE("Logger.Error", Bridge_Monitor_Logger_Error);
DEFINE_NATIVE("Logger.ErrorCategory", Bridge_Monitor_Logger_ErrorCategory);
DEFINE_NATIVE("Logger.Debug", Bridge_Monitor_Logger_Debug);
DEFINE_NATIVE("Logger.DebugCategory", Bridge_Monitor_Logger_DebugCategory);
DEFINE_NATIVE("Logger.SetLogFile", Bridge_Monitor_Logger_SetLogFile);
DEFINE_NATIVE("Logger.ShouldOutputToFile", Bridge_Monitor_Logger_ShouldOutputToFile);
DEFINE_NATIVE("Logger.ShouldColorCategoryInConsole", Bridge_Monitor_Logger_ShouldColorCategoryInConsole);
DEFINE_NATIVE("Logger.ShouldOutputToConsole", Bridge_Monitor_Logger_ShouldOutputToConsole);