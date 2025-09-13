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

#include "manager.h"

#include <api/interfaces/manager.h>

#include <core/entrypoint.h>

uint64_t playerMask = 0;

IVFunctionHook* g_pClientConnectHook = nullptr;
IVFunctionHook* g_pClientConnectedHook = nullptr;
IVFunctionHook* g_pClientDisconnectHook = nullptr;

void CPlayerManager::Initialize()
{
    g_Players = new CPlayer * [g_SwiftlyCore.GetMaxGameClients()];
    for (int i = 0; i < g_SwiftlyCore.GetMaxGameClients(); i++) {
        g_Players[i] = nullptr;
    }

    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);

    g_pClientConnectHook = hooksmanager->CreateVFunctionHook();
    g_pClientConnectedHook = hooksmanager->CreateVFunctionHook();
    g_pClientDisconnectHook = hooksmanager->CreateVFunctionHook();

    g_pClientConnectHook->SetHookFunction(INTERFACEVERSION_SERVERGAMECLIENTS, GetVirtualFunctionId(&IServerGameClients::ClientConnect), "pisUsbp", 'b');
    g_pClientConnectedHook->SetHookFunction(INTERFACEVERSION_SERVERGAMECLIENTS, GetVirtualFunctionId(&IServerGameClients::OnClientConnected), "pisUssb", 'v');
    g_pClientDisconnectHook->SetHookFunction(INTERFACEVERSION_SERVERGAMECLIENTS, GetVirtualFunctionId(&IServerGameClients::ClientDisconnect), "piusUs", 'v');

    g_pClientConnectHook->SetCallback(dyno::CallbackType::Pre, [](dyno::CallbackType m_cbType, dyno::IHook& hook) -> dyno::ReturnAction {
        auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
        auto playerid = hook.getArgument<CPlayerSlot>(1).Get();
        auto player = playermanager->RegisterPlayer(playerid);
        player->Initialize(playerid);

        return dyno::ReturnAction::Ignored;
    });

    g_pClientConnectedHook->SetCallback(dyno::CallbackType::Pre, [](dyno::CallbackType m_cbType, dyno::IHook& hook) -> dyno::ReturnAction {
        auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
        auto playerid = hook.getArgument<CPlayerSlot>(1).Get();
        auto isFakeClient = hook.getArgument<bool>(6);
        if (isFakeClient) {
            auto player = playermanager->RegisterPlayer(playerid);
            player->Initialize(playerid);
        }
        else {
            auto cvarmanager = g_ifaceService.FetchInterface<IConvarManager>(CONVARMANAGER_INTERFACE_VERSION);
            cvarmanager->QueryClientConvar(playerid, "cl_language");
        }

        return dyno::ReturnAction::Ignored;
    });

    g_pClientDisconnectHook->SetCallback(dyno::CallbackType::Post, [](dyno::CallbackType m_cbType, dyno::IHook& hook) -> dyno::ReturnAction {
        auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
        auto playerid = hook.getArgument<CPlayerSlot>(1).Get();
        playermanager->UnregisterPlayer(playerid);
        return dyno::ReturnAction::Ignored;
    });

    g_pClientConnectHook->Enable();
    g_pClientConnectedHook->Enable();
    g_pClientDisconnectHook->Enable();
}

void CPlayerManager::Shutdown() {
    if (g_pClientConnectHook) g_pClientConnectHook->Disable();
    if (g_pClientConnectedHook) g_pClientConnectedHook->Disable();
    if (g_pClientDisconnectHook) g_pClientDisconnectHook->Disable();

    for (int i = 0; i < g_SwiftlyCore.GetMaxGameClients(); i++) {
        if (g_Players[i] != nullptr) {
            delete g_Players[i];
        }
    }
    delete[] g_Players;
}

IPlayer* CPlayerManager::RegisterPlayer(int playerid)
{
    if (playerid < 0 || playerid >= g_SwiftlyCore.GetMaxGameClients()) return nullptr;

    if (g_Players[playerid] != nullptr) UnregisterPlayer(playerid);

    g_Players[playerid] = new CPlayer();
    g_Players[playerid]->Initialize(playerid);

    playerMask |= (1ULL << playerid);

    return g_Players[playerid];
}

void CPlayerManager::UnregisterPlayer(int playerid)
{
    if (playerid < 0 || playerid >= g_SwiftlyCore.GetMaxGameClients()) return;
    if (g_Players[playerid] == nullptr) return;

    g_Players[playerid]->Shutdown();
    delete g_Players[playerid];
    g_Players[playerid] = nullptr;

    playerMask &= ~(1ULL << playerid);
}

IPlayer* CPlayerManager::GetPlayer(int playerid)
{
    if (playerid < 0 || playerid >= g_SwiftlyCore.GetMaxGameClients()) return nullptr;
    if (playerMask & (1ULL << playerid)) return g_Players[playerid];
    return nullptr;
}

bool CPlayerManager::IsPlayerOnline(int playerid)
{
    if (playerid < 0 || playerid >= g_SwiftlyCore.GetMaxGameClients()) return false;
    return (playerMask & (1ULL << playerid)) != 0;
}

int CPlayerManager::GetPlayerCount()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    int count = 0;

    for (int i = 0; i < GetPlayerCap(); i++)
        if (engine->GetClientSteamID(i)) ++count;

    return count;
}

int CPlayerManager::GetPlayerCap()
{
    return g_SwiftlyCore.GetMaxGameClients();
}

void CPlayerManager::SendMsg(MessageType type, const std::string& message)
{
    for (int i = 0; i < g_SwiftlyCore.GetMaxGameClients(); i++) {
        IPlayer* player = GetPlayer(i);
        if (player) player->SendMsg(type, message);
    }
}

void CPlayerManager::SteamAPIServerActivated()
{
    m_CallbackValidateAuthTicketResponse.Register(this, &CPlayerManager::OnValidateAuthTicket);
}

void CPlayerManager::OnValidateAuthTicket(ValidateAuthTicketResponse_t* response)
{
    uint64_t steamid = response->m_SteamID.ConvertToUint64();

    for (int i = 0; i < GetPlayerCap(); i++) {
        auto player = GetPlayer(i);
        if (!player) continue;
        if (player->GetUnauthorizedSteamID() != steamid) continue;

        player->ChangeAuthorizationState(response->m_eAuthSessionResponse == k_EAuthSessionResponseOK);
        break;
    }
}