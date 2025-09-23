/************************************************************************************************
 * SwiftlyS2 is a scripting framework for Source2-based games.
 * Copyright (C) 2025 Swiftly Solution SRL via Sava Andrei-Sebastian and it's contributors
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 ************************************************************************************************/

#include <api/interfaces/manager.h>
#include <api/shared/files.h>
#include <api/shared/string.h>

#include <core/entrypoint.h>
#include <scripting/scripting.h>

#include <public/filesystem.h>
#include <public/steam/isteamgameserver.h>
#include <igamesystemfactory.h>

#include <core/bridge/metamod.h>

int Bridge_EngineHelpers_GetServerIP(char* out)
{
    static std::string s;
    if (!g_SteamAPI.SteamGameServer()) s = "0.0.0.0";
    else {
        auto ip_addr = g_SteamAPI.SteamGameServer()->GetPublicIP();
        s = std::format("{}.{}.{}.{}", (ip_addr.m_unIPv4 >> 24) & 0xFF, (ip_addr.m_unIPv4 >> 16) & 0xFF, (ip_addr.m_unIPv4 >> 8) & 0xFF, ip_addr.m_unIPv4 & 0xFF);
    }

    if (out != nullptr) strcpy(out, s.c_str());

    return s.size();
}

int Bridge_EngineHelpers_GetMap(char* out)
{
    static std::string s;
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    if (!engine) s = "unknown_map";
    else {
        auto globals = engine->GetServerGlobals();
        if (!globals) {
            s = "unknown_map";
        }
        else {
            s = globals->mapname.ToCStr();
        }
    }

    if (out != nullptr) strcpy(out, s.c_str());
    return s.size();
}

bool Bridge_EngineHelpers_IsMapValid(const char* map_name)
{
    if (!map_name) return false;

    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    auto filesystem = g_ifaceService.FetchInterface<IFileSystem>(FILESYSTEM_INTERFACE_VERSION);

    static CBufferStringGrowable<MAX_PATH> s_sWorkingDir;
    ExecuteOnce(filesystem->GetSearchPath("EXECUTABLE_PATH", GET_SEARCH_PATH_ALL, s_sWorkingDir, 1));

    return (
        engine->IsMapValid(map_name) ||
        Files::ExistsPath(std::format("{}steamapps/workshop/content/730/{}/{}.vpk", s_sWorkingDir.Get(), map_name, map_name)) ||
        Files::ExistsPath(std::format("{}steamapps/workshop/content/730/{}/{}_dir.vpk", s_sWorkingDir.Get(), map_name, map_name))
    );
}

int Bridge_EngineHelpers_GetMaxPlayers()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    if (!engine) return 0;

    return engine->GetServerGlobals()->maxClients;
}

void Bridge_EngineHelpers_ExecuteCommand(const char* command)
{
    if (!command) return;

    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    if (!engine) return;

    engine->ServerCommand(command);
}

float Bridge_EngineHelpers_GetServerCurrentTime()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    if (!engine) return 0.0f;

    return engine->GetServerGlobals()->curtime;
}

int Bridge_EngineHelpers_GetServerTickCount()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    if (!engine) return 0;

    return engine->GetServerGlobals()->tickcount;
}

void* Bridge_EngineHelpers_FindGameSystemByName(const char* name)
{
    return CBaseGameSystemFactory::GetGlobalPtrByName(name);
}

void Bridge_EngineHelpers_SendMessageToConsole(const char* message)
{
    g_SwiftlyCore.SendConsoleMessage(TerminalProcessColor(message));
}

void* g_pTraceManager = nullptr;

void* Bridge_EngineHelpers_GetTraceManager()
{
    return g_pTraceManager;
}

DEFINE_NATIVE("EngineHelpers.GetServerIP", Bridge_EngineHelpers_GetServerIP);
DEFINE_NATIVE("EngineHelpers.GetMap", Bridge_EngineHelpers_GetMap);
DEFINE_NATIVE("EngineHelpers.IsMapValid", Bridge_EngineHelpers_IsMapValid);
DEFINE_NATIVE("EngineHelpers.GetMaxPlayers", Bridge_EngineHelpers_GetMaxPlayers);
DEFINE_NATIVE("EngineHelpers.ExecuteCommand", Bridge_EngineHelpers_ExecuteCommand);
DEFINE_NATIVE("EngineHelpers.GetServerCurrentTime", Bridge_EngineHelpers_GetServerCurrentTime);
DEFINE_NATIVE("EngineHelpers.GetServerTickCount", Bridge_EngineHelpers_GetServerTickCount);
DEFINE_NATIVE("EngineHelpers.FindGameSystemByName", Bridge_EngineHelpers_FindGameSystemByName);
DEFINE_NATIVE("EngineHelpers.SendMessageToConsole", Bridge_EngineHelpers_SendMessageToConsole);
DEFINE_NATIVE("EngineHelpers.GetTraceManager", Bridge_EngineHelpers_GetTraceManager);