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

#include "manager.h"
#include <api/shared/plat.h>
#include <api/dll/functions.h>

typedef void* (*GetInterfaceFn)(const char*);

void* InterfacesManager::GetPureInterface(const std::string& interface_name)
{
#ifdef BUILDING_CORE
    return ::GetPureInterface(interface_name.c_str());
#else
    void* getiface_func = GetBinaryFunction(WIN_LINUX("addons\\swiftly\\bin\\win64\\swiftly.dll", "addons/swiftly/bin/linuxsteamrt64/swiftly.so"), "GetPureInterface");
    if (!getiface_func) return nullptr;

    GetInterfaceFn GetInterface = reinterpret_cast<GetInterfaceFn>(getiface_func);
    return GetInterface(interface_name.c_str());
#endif
}