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
#include <monitor/logger/logger.h>
#include <monitor/resmon/monitor.h>
#include <memory/allocator/allocator.h>
#include <map>

ExtensionManager g_ExtensionsManager;
Logger g_Logger;
ResourceMonitor g_ResourceMonitor;
MemoryAllocator g_MemoryAllocator;

static std::map<std::string, void*> g_Interfaces = {
    {EXTENSIONMANAGER_INTERFACE_VERSION, &g_ExtensionsManager},
    {LOGGER_INTERFACE_VERSION, &g_Logger},
    {RESOURCE_MONITOR_INTERFACE_VERSION, &g_ResourceMonitor},
    {MEMORYALLOCATOR_INTERFACE_VERSION, &g_MemoryAllocator},
};

SW_API void* GetPureInterface(const char* iface_name)
{
    if (!g_Interfaces.contains(iface_name)) return g_SwiftlyCore.GetInterface(iface_name);
    return g_Interfaces.at(iface_name);
}