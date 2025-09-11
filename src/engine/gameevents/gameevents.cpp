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

#include "gameevents.h"

#include <api/interfaces/manager.h>

#include <api/shared/files.h>
#include <api/shared/jsonc.h>

#include <memory/gamedata/manager.h>

#include <public/iserver.h>

#include <map>
#include <stack>

#include <nlohmann/json.hpp>

using json = nlohmann::json;

std::map<uint64_t, std::function<bool(std::string, IGameEvent*, bool&)>> g_mEventListeners;
std::map<uint64_t, std::function<bool(std::string, IGameEvent*, bool&)>> g_mPostEventListeners;

std::vector<std::string> g_vEventNames;
std::stack<IGameEvent*> g_sEventStack;
std::set<std::string> g_sEnqueueListenEvents;
bool g_bEventsLoaded = false;

IVFunctionHook* g_pLoadEventsFromFile = nullptr;
IVFunctionHook* g_pFireEvent = nullptr;
IVFunctionHook* g_pStartupServer = nullptr;
IGameEventManager2* g_gameEventManager = nullptr;

void CEventManager::Initialize(std::string game_name)
{
    std::string file_path = "addons/swiftly/gamedata/" + game_name + "/gameevents.json";
    json j = parseJsonc(Files::Read(file_path));
    for (const auto& item : j)
    {
        g_vEventNames.push_back(item.get<std::string>());
    }

    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Debug("Game Events", std::format("Loaded {} events from gamedata.\n", g_vEventNames.size()));

    DynLibUtils::CModule servermodule = DetermineModuleByLibrary("server");
    auto CGameEventManagerVTable = servermodule.GetVirtualTableByName("CGameEventManager");

    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);
    g_pLoadEventsFromFile = hooksmanager->CreateVFunctionHook();

    g_pLoadEventsFromFile->SetHookFunction(CGameEventManagerVTable, GetVirtualFunctionId(&IGameEventManager2::LoadEventsFromFile), "psb", 'v', true);

    g_pLoadEventsFromFile->SetCallback(dyno::CallbackType::Pre, [](dyno::CallbackType cb, dyno::IHook& hook) -> dyno::ReturnAction {
        if (g_gameEventManager) return dyno::ReturnAction::Ignored;

        g_gameEventManager = hook.getArgument<IGameEventManager2*>(0);

        auto evmanager = g_ifaceService.FetchInterface<IEventManager>(GAMEEVENTMANAGER_INTERFACE_VERSION);
        evmanager->RegisterGameEventsListeners(false);

        return dyno::ReturnAction::Ignored;
    });

    g_pLoadEventsFromFile->Enable();
}

void CEventManager::Shutdown()
{
    if (g_pLoadEventsFromFile)
        g_pLoadEventsFromFile->Disable();
}

void CEventManager::RegisterGameEventsListeners(bool shouldRegister)
{
    if (!g_gameEventManager) return;

    if (shouldRegister && !g_bEventsLoaded) {
        g_bEventsLoaded = true;

        for (auto it = g_sEnqueueListenEvents.begin(); it != g_sEnqueueListenEvents.end(); ++it)
            RegisterGameEventListener(*it);

        g_sEnqueueListenEvents.clear();
    }

    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);

    if (!g_pFireEvent) {
        g_pFireEvent = hooksmanager->CreateVFunctionHook();
        g_pFireEvent->SetHookFunction(g_gameEventManager, GetVirtualFunctionId(&IGameEventManager2::FireEvent), "ppb", 'v', false);

        g_pFireEvent->SetCallback(dyno::CallbackType::Pre, [](dyno::CallbackType cb, dyno::IHook& hook) -> dyno::ReturnAction {
            IGameEvent* event = hook.getArgument<IGameEvent*>(1);
            if (!event) return dyno::ReturnAction::Ignored;

            std::string event_name = event->GetName();
            bool shouldBroadcast = hook.getArgument<bool>(2);
            for (const auto& [id, callback] : g_mEventListeners)
                if (!callback(event_name, event, shouldBroadcast)) {
                    g_gameEventManager->FreeEvent(event);
                    hook.setReturn(false);
                    return dyno::ReturnAction::Supercede;
                }

            g_sEventStack.push(g_gameEventManager->DuplicateEvent(event));

            if (shouldBroadcast != hook.getArgument<bool>(2))
            {
                hook.setArgument<bool>(2, shouldBroadcast);
            }

            return dyno::ReturnAction::Ignored;
        });

        g_pFireEvent->SetCallback(dyno::CallbackType::Post, [](dyno::CallbackType cb, dyno::IHook& hook) -> dyno::ReturnAction {
            IGameEvent* realGameEvent = g_sEventStack.top();
            if (!realGameEvent) return dyno::ReturnAction::Ignored;

            std::string event_name = realGameEvent->GetName();
            bool shouldBroadcast = hook.getArgument<bool>(2);

            for (const auto& [id, callback] : g_mEventListeners)
                if (!callback(event_name, realGameEvent, shouldBroadcast)) {
                    g_gameEventManager->FreeEvent(realGameEvent);
                    g_sEventStack.pop();
                    hook.setReturn(false);
                    return dyno::ReturnAction::Supercede;
                }

            g_gameEventManager->FreeEvent(realGameEvent);
            g_sEventStack.pop();
            return dyno::ReturnAction::Ignored;
        });

        g_pFireEvent->Enable();
    }

    if (!g_pStartupServer) {
        g_pStartupServer = hooksmanager->CreateVFunctionHook();

        g_pStartupServer->SetHookFunction(NETWORKSERVERSERVICE_INTERFACE_VERSION, GetVirtualFunctionId(&INetworkServerService::StartupServer), "ppps", 'v');

        g_pStartupServer->SetCallback(dyno::CallbackType::Post, [](dyno::CallbackType cb, dyno::IHook& hook) -> dyno::ReturnAction {
            auto evmanager = g_ifaceService.FetchInterface<IEventManager>(GAMEEVENTMANAGER_INTERFACE_VERSION);
            evmanager->RegisterGameEventsListeners(true);
            return dyno::ReturnAction::Ignored;
        });

        g_pStartupServer->Enable();
    }
}

void CEventManager::RegisterGameEventListener(std::string event_name)
{
    if (!g_bEventsLoaded) {
        g_sEnqueueListenEvents.insert(event_name);
    }
    else {
        if (!g_gameEventManager) return;

        if (!g_gameEventManager->FindListener(this, event_name.c_str()))
            g_gameEventManager->AddListener(this, event_name.c_str(), true);

        auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
        logger->Debug("Game Events", std::format("Registered listener for event '{}'.\n", event_name));
    }
}

uint64_t CEventManager::AddGameEventFireListener(std::function<bool(std::string, IGameEvent*, bool&)> callback)
{
    static uint64_t s_uiListenerID = 0;
    g_mEventListeners[++s_uiListenerID] = callback;
    return s_uiListenerID;
}

uint64_t CEventManager::AddPostGameEventFireListener(std::function<bool(std::string, IGameEvent*, bool&)> callback)
{
    static uint64_t s_uiListenerID = 0;
    g_mPostEventListeners[++s_uiListenerID] = callback;
    return s_uiListenerID;
}

void CEventManager::RemoveGameEventFireListener(uint64_t listener_id)
{
    auto it = g_mEventListeners.find(listener_id);
    if (it != g_mEventListeners.end())
    {
        g_mEventListeners.erase(it);
    }
}

void CEventManager::RemovePostGameEventFireListener(uint64_t listener_id)
{
    auto it = g_mPostEventListeners.find(listener_id);
    if (it != g_mPostEventListeners.end())
    {
        g_mPostEventListeners.erase(it);
    }
}

IGameEventManager2* CEventManager::GetGameEventManager()
{
    return g_gameEventManager;
}

void CEventManager::FireGameEvent(IGameEvent* event) {}