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

#include <core/bridge/metamod.h>
#include <core/entrypoint.h>

SH_DECL_EXTERN6(IServerGameClients, ClientConnect, SH_NOATTRIB, 0, bool, CPlayerSlot, const char*, uint64_t, const char*, bool, CBufferString*);
SH_DECL_EXTERN6_void(IServerGameClients, OnClientConnected, SH_NOATTRIB, 0, CPlayerSlot, const char*, uint64_t, const char*, const char*, bool);
SH_DECL_EXTERN5_void(IServerGameClients, ClientDisconnect, SH_NOATTRIB, 0, CPlayerSlot, ENetworkDisconnectionReason, const char*, uint64_t, const char*);

uint64_t playerMask = 0;

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

    // g_pClientConnectHook->SetHookFunction(INTERFACEVERSION_SERVERGAMECLIENTS, GetVirtualFunctionId(&IServerGameClients::ClientConnect), "pisUsbp", 'b');
    // g_pClientConnectedHook->SetHookFunction(INTERFACEVERSION_SERVERGAMECLIENTS, GetVirtualFunctionId(&IServerGameClients::OnClientConnected), "pisUssb", 'v');
    // g_pClientDisconnectHook->SetHookFunction(INTERFACEVERSION_SERVERGAMECLIENTS, GetVirtualFunctionId(&IServerGameClients::ClientDisconnect), "piusUs", 'v');

    // g_pClientConnectHook->SetCallback(dyno::CallbackType::Pre, [](dyno::CallbackType m_cbType, dyno::IHook& hook) -> dyno::ReturnAction {
    //     auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    //     auto playerid = hook.getArgument<CPlayerSlot>(1).Get();
    //     auto player = playermanager->RegisterPlayer(playerid);
    //     player->Initialize(playerid);

    //     return dyno::ReturnAction::Ignored;
    // });

    // g_pClientConnectedHook->SetCallback(dyno::CallbackType::Pre, [](dyno::CallbackType m_cbType, dyno::IHook& hook) -> dyno::ReturnAction {
    //     auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    //     auto playerid = hook.getArgument<CPlayerSlot>(1).Get();
    //     auto isFakeClient = hook.getArgument<bool>(6);
    //     if (isFakeClient) {
    //         auto player = playermanager->RegisterPlayer(playerid);
    //         player->Initialize(playerid);
    //     }
    //     else {
    //         auto cvarmanager = g_ifaceService.FetchInterface<IConvarManager>(CONVARMANAGER_INTERFACE_VERSION);
    //         cvarmanager->QueryClientConvar(playerid, "cl_language");
    //     }

    //     return dyno::ReturnAction::Ignored;
    // });

    // g_pClientDisconnectHook->SetCallback(dyno::CallbackType::Post, [](dyno::CallbackType m_cbType, dyno::IHook& hook) -> dyno::ReturnAction {
    //     auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    //     auto playerid = hook.getArgument<CPlayerSlot>(1).Get();
    //     playermanager->UnregisterPlayer(playerid);
    //     return dyno::ReturnAction::Ignored;
    // });

    // g_pClientConnectHook->Enable();
    // g_pClientConnectedHook->Enable();
    // g_pClientDisconnectHook->Enable();
}

void CPlayerManager::Shutdown() {
    for (int i = 0; i < g_SwiftlyCore.GetMaxGameClients(); i++) {
        if (g_Players[i] != nullptr) {
            delete g_Players[i];
        }
    }
    delete[] g_Players;

    auto gameclients = g_ifaceService.FetchInterface<IServerGameClients>(INTERFACEVERSION_SERVERGAMECLIENTS);

    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, ClientConnect, gameclients, this, &CPlayerManager::ClientConnect, false);
    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, OnClientConnected, gameclients, this, &CPlayerManager::OnClientConnected, false);
    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, ClientDisconnect, gameclients, this, &CPlayerManager::ClientDisconnect, true);
}

bool CPlayerManager::ClientConnect(CPlayerSlot slot, const char* pszName, uint64_t xuid, const char* pszNetworkID, bool unk1, CBufferString* pRejectReason)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto playerid = slot.Get();
    auto player = playermanager->RegisterPlayer(playerid);
    player->Initialize(playerid);

    RETURN_META_VALUE(MRES_IGNORED, true);
}

void CPlayerManager::OnClientConnected(CPlayerSlot slot, const char* pszName, uint64_t xuid, const char* pszNetworkID, const char* pszAddress, bool bFakePlayer)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto playerid = slot.Get();
    if (bFakePlayer) {
        auto player = playermanager->RegisterPlayer(playerid);
        player->Initialize(playerid);
    }
    else {
        auto cvarmanager = g_ifaceService.FetchInterface<IConvarManager>(CONVARMANAGER_INTERFACE_VERSION);
        cvarmanager->QueryClientConvar(playerid, "cl_language");
    }
}

void CPlayerManager::ClientDisconnect(CPlayerSlot slot, ENetworkDisconnectionReason reason, const char* pszName, uint64_t xuid, const char* pszNetworkID)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto playerid = slot.Get();
    playermanager->UnregisterPlayer(playerid);
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