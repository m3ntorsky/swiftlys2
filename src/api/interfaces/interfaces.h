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

#ifndef _api_interfaces_interfaces_h
#define _api_interfaces_interfaces_h

#include <string>
#include <api/dll/extern.h>

#include <api/extensions/extension.h>
#include <api/extensions/manager.h>
#include <api/extensions/plugin.h>

#include <api/monitor/logger/logger.h>

SW_API void* GetPureInterface(const char* iface_name);

#define EXTENSIONMANAGER_INTERFACE_VERSION                  "ExtensionManagerAPI"
#define LOGGER_INTERFACE_VERSION                            "LoggerAPI"

#endif