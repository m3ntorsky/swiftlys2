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

bool Bridge_Monitor_Resmon_IsEnabled()
{
    auto resmon = g_ifaceService.FetchInterface<IResourceMonitor>(RESOURCE_MONITOR_INTERFACE_VERSION);
    return resmon->IsEnabled();
}

void Bridge_Monitor_Resmon_RecordTime(const char* resourceName, const char* key, double time)
{
    auto resmon = g_ifaceService.FetchInterface<IResourceMonitor>(RESOURCE_MONITOR_INTERFACE_VERSION);
    resmon->RecordTime(resourceName, key, time);
}

void Bridge_Monitor_Resmon_StartRecording(const char* resourceName, const char* key)
{
    auto resmon = g_ifaceService.FetchInterface<IResourceMonitor>(RESOURCE_MONITOR_INTERFACE_VERSION);
    resmon->StartRecording(resourceName, key);
}

void Bridge_Monitor_Resmon_StopRecording(const char* resourceName, const char* key)
{
    auto resmon = g_ifaceService.FetchInterface<IResourceMonitor>(RESOURCE_MONITOR_INTERFACE_VERSION);
    resmon->StopRecording(resourceName, key);
}

DEFINE_NATIVE("Resmon.IsEnabled", Bridge_Monitor_Resmon_IsEnabled);
DEFINE_NATIVE("Resmon.RecordTime", Bridge_Monitor_Resmon_RecordTime);
DEFINE_NATIVE("Resmon.StartRecording", Bridge_Monitor_Resmon_StartRecording);
DEFINE_NATIVE("Resmon.StopRecording", Bridge_Monitor_Resmon_StopRecording);