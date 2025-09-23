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

#include <public/tier0/icommandline.h>
#include <public/tier1/utlstringtoken.h>

#include <api/shared/string.h>

typedef void* (*GetInterfaceFn)(const char*);

void* InterfacesManager::GetPureInterface(const std::string& interface_name)
{
#ifdef BUILDING_CORE
    return ::GetPureInterface(interface_name.c_str());
#else
    static std::string m_sCorePath = CommandLine()->ParmValue(CUtlStringToken("-sw_path"), "addons/swiftlys2");
    if (!ends_with(m_sCorePath, WIN_LINUX("\\", "/"))) m_sCorePath += WIN_LINUX("\\", "/");

    void* getiface_func = GetBinaryFunction(m_sCorePath + "bin/" + WIN_LINUX("win64/swiftly.dll", "linuxsteamrt64/swiftly.so"), "GetPureInterface");
    if (!getiface_func) return nullptr;

    GetInterfaceFn GetInterface = reinterpret_cast<GetInterfaceFn>(getiface_func);
    return GetInterface(interface_name.c_str());
#endif
}