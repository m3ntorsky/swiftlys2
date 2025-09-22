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

void Bridge_Player_SendMessage(int playerid, int kind, const char* message)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return;

    player->SendMsg((MessageType)kind, message);
}

bool Bridge_Player_IsFakeClient(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return true;

    return player->IsFakeClient();
}

bool Bridge_Player_IsAuthorized(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return false;

    return player->IsAuthorized();
}

uint32_t Bridge_Player_GetConnectedTime(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return 0;

    return player->GetConnectedTime();
}

uint64_t Bridge_Player_GetUnauthorizedSteamID(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return 0;

    return player->GetUnauthorizedSteamID();
}

uint64_t Bridge_Player_GetSteamID(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return 0;

    return player->GetSteamID();
}

void* Bridge_Player_GetController(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return nullptr;

    return player->GetController();
}

void* Bridge_Player_GetPawn(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return nullptr;

    return player->GetPawn();
}

void* Bridge_Player_GetPlayerPawn(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return nullptr;

    return player->GetPlayerPawn();
}

uint64_t Bridge_Player_GetPressedButtons(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return 0;

    return player->GetPressedButtons();
}

void Bridge_Player_PerformCommand(int playerid, const char* command)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return;

    player->PerformCommand(command);
}

int Bridge_Player_GetIPAddress(char* out, int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return 0;

    static std::string s;
    s = player->GetIPAddress();

    if (out != nullptr) strcpy(out, s.c_str());

    return s.size();
}

void Bridge_Player_Kick(int playerid, const char* reason, int gamereason)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return;

    player->Kick(reason, (ENetworkDisconnectionReason)gamereason);
}

void Bridge_Player_ShouldBlockTransmitEntity(int playerid, int entityidx, bool shouldBlockTransmit)
{
    if (playerid + 1 == entityidx) return;

    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return;

    auto& bv = player->GetBlockedTransmittingBits();

    if (shouldBlockTransmit)
        bv.Set(entityidx);
    else
        bv.Clear(entityidx);
}

bool Bridge_Player_IsTransmitEntityBlocked(int playerid, int entityidx)
{
    if (playerid + 1 == entityidx) return false;

    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return false;

    auto& bv = player->GetBlockedTransmittingBits();
    return bv.IsBitSet(entityidx);
}

void Bridge_Player_ClearTransmitEntityBlocked(int playerid)
{
    static auto playerManager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playerManager->GetPlayer(playerid);
    if (!player) return;

    auto& bv = player->GetBlockedTransmittingBits();
    bv.ClearAll();
}

DEFINE_NATIVE("Player.SendMessage", Bridge_Player_SendMessage);
DEFINE_NATIVE("Player.IsFakeClient", Bridge_Player_IsFakeClient);
DEFINE_NATIVE("Player.IsAuthorized", Bridge_Player_IsAuthorized);
DEFINE_NATIVE("Player.GetConnectedTime", Bridge_Player_GetConnectedTime);
DEFINE_NATIVE("Player.GetUnauthorizedSteamID", Bridge_Player_GetUnauthorizedSteamID);
DEFINE_NATIVE("Player.GetSteamID", Bridge_Player_GetSteamID);
DEFINE_NATIVE("Player.GetController", Bridge_Player_GetController);
DEFINE_NATIVE("Player.GetPawn", Bridge_Player_GetPawn);
DEFINE_NATIVE("Player.GetPlayerPawn", Bridge_Player_GetPlayerPawn);
DEFINE_NATIVE("Player.GetPressedButtons", Bridge_Player_GetPressedButtons);
DEFINE_NATIVE("Player.PerformCommand", Bridge_Player_PerformCommand);
DEFINE_NATIVE("Player.GetIPAddress", Bridge_Player_GetIPAddress);
DEFINE_NATIVE("Player.Kick", Bridge_Player_Kick);
DEFINE_NATIVE("Player.ShouldBlockTransmitEntity", Bridge_Player_ShouldBlockTransmitEntity);
DEFINE_NATIVE("Player.IsTransmitEntityBlocked", Bridge_Player_IsTransmitEntityBlocked);
DEFINE_NATIVE("Player.ClearTransmitEntityBlocked", Bridge_Player_ClearTransmitEntityBlocked);