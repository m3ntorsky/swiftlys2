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
#include <api/interfaces/interfaces.h>
#include <api/scripting/scripting.h>    
#include <api/memory/hooks/manager.h>
#include "console/colors.h"
#include <core/managed/host/host.h>

#include <engine/entities/listener.h>
#include <engine/entities/entitysystem.h>
#include <engine/gamesystem/gamesystem.h>

#include <public/tier0/icommandline.h>
#include <public/tier1/utlstringtoken.h>

#include <api/shared/plat.h>
#include <api/shared/string.h>

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

    m_sCorePath = CommandLine()->ParmValue(CUtlStringToken("-sw_path"), WIN_LINUX("addons\\swiftlys2", "addons/swiftlys2"));
    if (!ends_with(m_sCorePath, WIN_LINUX("\\", "/"))) m_sCorePath += WIN_LINUX("\\", "/");

    auto configuration = g_ifaceService.FetchInterface<IConfiguration>(CONFIGURATION_INTERFACE_VERSION);
    configuration->InitializeExamples();

    if (!configuration->Load()) {
        logger->Error("Entrypoint", "Couldn't load the core configuration.");
        return false;
    }

    auto sdkclass = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);
    sdkclass->Load();

    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);

    gamedata->GetOffsets()->Load(GetCurrentGame());
    gamedata->GetSignatures()->Load(GetCurrentGame());
    gamedata->GetPatches()->Load(GetCurrentGame());

    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->Initialize();

    auto cvarmanager = g_ifaceService.FetchInterface<IConvarManager>(CONVARMANAGER_INTERFACE_VERSION);
    cvarmanager->Initialize();

    auto evmanager = g_ifaceService.FetchInterface<IEventManager>(GAMEEVENTMANAGER_INTERFACE_VERSION);
    evmanager->Initialize(GetCurrentGame());

    if (!InitGameSystem()) {
        logger->Error("Game System", "Couldn't initialize the Game System.\n");
        return false;
    }

    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    playermanager->Initialize();

    auto databasemanager = g_ifaceService.FetchInterface<IDatabaseManager>(DATABASEMANAGER_INTERFACE_VERSION);
    databasemanager->Initialize();

    auto translations = g_ifaceService.FetchInterface<ITranslations>(TRANSLATIONS_INTERFACE_VERSION);
    translations->Initialize();

    auto netmessages = g_ifaceService.FetchInterface<INetMessages>(NETMESSAGES_INTERFACE_VERSION);
    netmessages->Initialize();

    auto servercommands = g_ifaceService.FetchInterface<IServerCommands>(SERVERCOMMANDS_INTERFACE_VERSION);
    servercommands->Initialize();

    IExtensionManager* extManager = g_ifaceService.FetchInterface<IExtensionManager>(EXTENSIONMANAGER_INTERFACE_VERSION);
    extManager->Load();

    auto scripting = g_ifaceService.FetchInterface<IScriptingAPI>(SCRIPTING_INTERFACE_VERSION);

    // servercommands->RegisterCommand("test", [](int playerid, std::vector<std::string> args, std::string command_name, std::string prefix, bool silent) {
    //     auto vgui = g_ifaceService.FetchInterface<IVGUI>(VGUI_INTERFACE_VERSION);
    //     auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);

    //     Color color(255, 255, 255, 255);

    //     std::string text = "hello world";

    //     float x = 0.0;
    //     float y = 1.0;

    //     if (x < 0.0) x = 0.0;
    //     if (x > 1.0) x = 1.0;

    //     if (y < 0.0) y = 0.0;
    //     if (y > 1.0) y = 1.0;

    //     std::string font_name = "Sans Serif";
    //     bool background = true;

    //     IPlayer* player = playermanager->GetPlayer(playerid);
    //     if (!player) return;

    //     uint64_t textID = vgui->RegisterScreenText();
    //     IScreenText* txt = vgui->GetScreenText(textID);

    //     txt->Create(color, font_name, 35, background, false);
    //     txt->SetText(text);
    //     txt->SetPlayer(player);
    //     txt->SetPosition(x, y);
    // }, false);

    InitializeHostFXR(std::string(Plat_GetGameDirectory()) + "/csgo/" + m_sCorePath);
    InitializeDotNetAPI(scripting->GetNativeFunctions(), scripting->GetNativeFunctionsCount());

    return true;
}

bool SwiftlyCore::Unload()
{
    IExtensionManager* extManager = g_ifaceService.FetchInterface<IExtensionManager>(EXTENSIONMANAGER_INTERFACE_VERSION);
    extManager->Unload();

    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    playermanager->Shutdown();

    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->Shutdown();

    auto cvarmanager = g_ifaceService.FetchInterface<IConvarManager>(CONVARMANAGER_INTERFACE_VERSION);
    cvarmanager->Shutdown();

    auto evmanager = g_ifaceService.FetchInterface<IEventManager>(GAMEEVENTMANAGER_INTERFACE_VERSION);
    evmanager->Shutdown();

    auto netmessages = g_ifaceService.FetchInterface<INetMessages>(NETMESSAGES_INTERFACE_VERSION);
    netmessages->Shutdown();

    auto servercommands = g_ifaceService.FetchInterface<IServerCommands>(SERVERCOMMANDS_INTERFACE_VERSION);
    servercommands->Shutdown();

    ShutdownGameSystem();

    return true;
}

std::string current_map = "";
extern void* g_pOnMapLoadCallback;
extern void* g_pOnMapUnloadCallback;

void SwiftlyCore::OnMapLoad(std::string map_name)
{
    current_map = map_name;

    if (g_pOnMapLoadCallback)
        reinterpret_cast<void(*)(const char*)>(g_pOnMapLoadCallback)(map_name.c_str());
}

void SwiftlyCore::OnMapUnload()
{
    if (g_pOnMapUnloadCallback)
        reinterpret_cast<void(*)(const char*)>(g_pOnMapUnloadCallback)(current_map.c_str());

    current_map = "";
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

int SwiftlyCore::GetMaxGameClients()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    if (!engine) return 0;

    switch (engine->GetAppID()) {
    case 730: return 64;
    default: return 0;
    }
}

std::string& SwiftlyCore::GetCorePath()
{
    return m_sCorePath;
}