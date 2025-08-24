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

#include "entrypoint.h"
#include "bridge/metamod.h"
#include <api/interfaces/manager.h>
#include "console/colors.h"

#include <api/memory/hooks/manager.h>

SwiftlyCore g_SwiftlyCore;
InterfacesManager g_ifaceService;

bool SwiftlyCore::Load(BridgeKind_t kind)
{
    m_iKind = kind;

    SetupConsoleColors();

    IExtensionManager* extManager = g_ifaceService.FetchInterface<IExtensionManager>(EXTENSIONMANAGER_INTERFACE_VERSION);
    if (extManager) extManager->Load();

    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);

    return true;
}

bool SwiftlyCore::Unload()
{
    return true;
}

void SwiftlyCore::OnMapLoad(std::string map_name)
{

}

void SwiftlyCore::OnMapUnload()
{

}

void* SwiftlyCore::GetInterface(const std::string& iface_name)
{
    if (m_iKind == BridgeKind_t::Metamod) return g_MMPluginBridge.GetInterface(iface_name);
    else return nullptr;
}

void SwiftlyCore::SendConsoleMessage(const std::string& message)
{
    if (m_iKind == BridgeKind_t::Metamod) g_MMPluginBridge.SendConsoleMessage(message);
}