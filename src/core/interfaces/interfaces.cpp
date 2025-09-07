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

#include <api/interfaces/interfaces.h>
#include <core/entrypoint.h>

#include <core/extensions/manager.h>

#include <engine/entities/entitysystem.h>

#include <memory/allocator/allocator.h>
#include <memory/hooks/manager.h>
#include <memory/gamedata/manager.h>

#include <monitor/logger/logger.h>
#include <monitor/resmon/monitor.h>
#include <monitor/callstack/callstack.h>
#include <monitor/crashreporter/crashreporter.h>

#include <sdk/schema.h>

#include <server/configuration/configuration.h>

#include <map>

ExtensionManager g_ExtensionsManager;
Logger g_Logger;
ResourceMonitor g_ResourceMonitor;
MemoryAllocator g_MemoryAllocator;
CallStack g_CallStack;
CrashReporter g_CrashReporter;
HooksManager g_HooksManager;
GameDataManager g_GameDataManager;
Configuration g_Configuration;
CEntSystem g_EntSystem;
CSDKSchema g_SDKSchema;

static std::map<std::string, void*> g_Interfaces = {
    {EXTENSIONMANAGER_INTERFACE_VERSION, &g_ExtensionsManager},
    {LOGGER_INTERFACE_VERSION, &g_Logger},
    {RESOURCE_MONITOR_INTERFACE_VERSION, &g_ResourceMonitor},
    {MEMORYALLOCATOR_INTERFACE_VERSION, &g_MemoryAllocator},
    {CALLSTACK_INTERFACE_VERSION, &g_CallStack},
    {CRASHREPORTER_INTERFACE_VERSION, &g_CrashReporter},
    {HOOKSMANAGER_INTERFACE_VERSION, &g_HooksManager},
    {GAMEDATA_INTERFACE_VERSION, &g_GameDataManager},
    {CONFIGURATION_INTERFACE_VERSION, &g_Configuration},
    {ENTITYSYSTEM_INTERFACE_VERSION, &g_EntSystem},
    {SDKSCHEMA_INTERFACE_VERSION, &g_SDKSchema},
};

SW_API void* GetPureInterface(const char* iface_name)
{
    if (!g_Interfaces.contains(iface_name)) return g_SwiftlyCore.GetInterface(iface_name);
    return g_Interfaces.at(iface_name);
}