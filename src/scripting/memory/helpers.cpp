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
#include <scripting/scripting.h>

#include <memory/gamedata/manager.h>

void* Bridge_MemoryHelpers_FetchInterfaceByName(const char* iface_name)
{
    return g_ifaceService.FetchInterface<void>(iface_name);
}

void* Bridge_MemoryHelpers_GetVirtualTableAddress(const char* binary, const char* vtable_name)
{
    auto bin = DetermineModuleByLibrary(binary);
    if (!bin.GetModuleBase()) return nullptr;

    auto vtable = bin.GetVirtualTableByName(vtable_name);
    return vtable.RCast<void*>();
}

DEFINE_NATIVE("MemoryHelpers.FetchInterfaceByName", Bridge_MemoryHelpers_FetchInterfaceByName);
DEFINE_NATIVE("MemoryHelpers.GetVirtualTableAddress", Bridge_MemoryHelpers_GetVirtualTableAddress);