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

#include "metamod.h"
#include "../entrypoint.h"

SwiftlyMMBridge g_MMPluginBridge;

PLUGIN_EXPOSE(SwiftlyMMBridge, g_MMPluginBridge);
bool SwiftlyMMBridge::Load(PluginId id, ISmmAPI* ismm, char* error, size_t maxlen, bool late)
{
    PLUGIN_SAVEVARS();
    g_SMAPI->AddListener(this, this);

    return g_SwiftlyCore.Load(BridgeKind_t::Metamod);
}

bool SwiftlyMMBridge::Unload(char* error, size_t maxlen)
{
    return g_SwiftlyCore.Unload();
}

void SwiftlyMMBridge::AllPluginsLoaded()
{

}

void SwiftlyMMBridge::OnLevelInit(char const* pMapName, char const* pMapEntities, char const* pOldLevel, char const* pLandmarkName, bool loadGame, bool background)
{
}

void SwiftlyMMBridge::OnLevelShutdown()
{
}

void* SwiftlyMMBridge::GetInterface(const std::string& interface_name)
{
    if (interface_name == FILESYSTEM_INTERFACE_VERSION)
        return g_SMAPI->VInterfaceMatch(g_SMAPI->GetFileSystemFactory(), FILESYSTEM_INTERFACE_VERSION, 0);
    else if (INTERFACEVERSION_SERVERGAMEDLL == interface_name || INTERFACEVERSION_SERVERGAMECLIENTS == interface_name || SOURCE2GAMEENTITIES_INTERFACE_VERSION == interface_name)
        return g_SMAPI->VInterfaceMatch(g_SMAPI->GetServerFactory(), interface_name.c_str(), 0);
    else
        return g_SMAPI->VInterfaceMatch(g_SMAPI->GetEngineFactory(), interface_name.c_str(), 0);
}

const char* SwiftlyMMBridge::GetAuthor()
{
    return "Swiftly Development Team";
}

const char* SwiftlyMMBridge::GetName()
{
    return "SwiftlyS2";
}

const char* SwiftlyMMBridge::GetDescription()
{
    return "Lua/C# Framework for Source2-based games";
}

const char* SwiftlyMMBridge::GetURL()
{
    return "https://github.com/swiftly-solution/swiftly";
}

const char* SwiftlyMMBridge::GetLicense()
{
    return "GNU GPLv3";
}

const char* SwiftlyMMBridge::GetVersion()
{
#ifndef SWIFTLY_VERSION
    return "Local";
#else
    return SWIFTLY_VERSION;
#endif
}

const char* SwiftlyMMBridge::GetDate()
{
    return __DATE__;
}

const char* SwiftlyMMBridge::GetLogTag()
{
    return "SwiftlyS2";
}
