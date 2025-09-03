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

    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);

    if (GetCurrentGame() == "unknown") {
        auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);

        if (engine) logger->Error("Entrypoint", std::format("Unknown game detected. App ID: {}", engine->GetAppID()));
        else logger->Error("Entrypoint", "Unknown game detected. No engine interface available.");

        return false;
    }

    auto configuration = g_ifaceService.FetchInterface<IConfiguration>(CONFIGURATION_INTERFACE_VERSION);
    if (configuration) {
        configuration->InitializeExamples();

        if (!configuration->Load()) {
            logger->Error("Entrypoint", "Couldn't load the core configuration.");
            return false;
        }
    }


    if (auto pb = std::get_if<bool>(&configuration->GetValue("Logger.SaveCoreMessagesToFile"))) {
        logger->ShouldOutputToFile(LogType::INFO, *pb);
        logger->ShouldOutputToFile(LogType::WARNING, *pb);
        logger->ShouldOutputToFile(LogType::ERR, *pb);
        logger->ShouldOutputToFile(LogType::DEBUG, *pb);

        if (*pb) {
            logger->SetLogFile(LogType::INFO, "addons/swiftly/logs/core/info.log");
            logger->SetLogFile(LogType::WARNING, "addons/swiftly/logs/core/warning.log");
            logger->SetLogFile(LogType::ERR, "addons/swiftly/logs/core/error.log");
            logger->SetLogFile(LogType::DEBUG, "addons/swiftly/logs/core/debug.log");
        }
    }

    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);

    gamedata->GetOffsets()->Load(GetCurrentGame());
    gamedata->GetSignatures()->Load(GetCurrentGame());
    gamedata->GetPatches()->Load(GetCurrentGame());

    IExtensionManager* extManager = g_ifaceService.FetchInterface<IExtensionManager>(EXTENSIONMANAGER_INTERFACE_VERSION);
    if (extManager) extManager->Load();

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

std::string SwiftlyCore::GetCurrentGame()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    if (!engine) return "unknown";

    switch (engine->GetAppID()) {
    case 730: return "cs2";
    default: return "unknown";
    }
}