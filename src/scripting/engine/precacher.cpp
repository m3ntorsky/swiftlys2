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

void Bridge_Precacher_AddItem(const char* itemPath)
{
    auto precacher = g_ifaceService.FetchInterface<IPrecacher>(PRECACHER_INTERFACE_VERSION);
    precacher->AddItem(itemPath);
}

bool Bridge_Precacher_HasItemInList(const char* itemPath)
{
    auto precacher = g_ifaceService.FetchInterface<IPrecacher>(PRECACHER_INTERFACE_VERSION);
    return precacher->HasItemInList(itemPath);
}

bool Bridge_Precacher_IsItemCached(const char* itemPath)
{
    auto precacher = g_ifaceService.FetchInterface<IPrecacher>(PRECACHER_INTERFACE_VERSION);
    return precacher->IsItemCached(itemPath);
}

void Bridge_Precacher_RemoveItem(const char* itemPath)
{
    auto precacher = g_ifaceService.FetchInterface<IPrecacher>(PRECACHER_INTERFACE_VERSION);
    precacher->RemoveItem(itemPath);
}

DEFINE_NATIVE("Precacher.AddItem", Bridge_Precacher_AddItem);
DEFINE_NATIVE("Precacher.HasItemInList", Bridge_Precacher_HasItemInList);
DEFINE_NATIVE("Precacher.IsItemCached", Bridge_Precacher_IsItemCached);
DEFINE_NATIVE("Precacher.RemoveItem", Bridge_Precacher_RemoveItem);