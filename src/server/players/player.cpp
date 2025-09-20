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

#include "player.h"

#include <api/shared/string.h>
#include <api/sdk/recipientfilter.h>

#include <public/networksystem/inetworkmessages.h>
#include <public/engine/igameeventsystem.h>

#include <public/const.h>
#include <game/shared/ehandle.h>

#include "usermessages.pb.h"

#define CBaseEntity_m_iTeamNum 0x9DC483B8A5BFEFB3
#define CBaseEntity_m_fFlags   0x9DC483B8A4A37590

#define CBasePlayerController_m_hPawn 0x3979FF6E7C628C1D
#define CCSPlayerController_m_hPlayerPawn 0x28ECD7A1D6C93E7C

void CPlayer::Initialize(int playerid)
{
    m_iPlayerId = playerid;
    m_bAuthorized = false;

    m_uConnectedTimeStart = std::chrono::high_resolution_clock::now();
}

void CPlayer::Shutdown()
{
    m_iPlayerId = -1;
    m_bAuthorized = false;
}

void CPlayer::SendMsg(MessageType type, const std::string& message)
{
    if (type == MessageType::CenterHTML) {

    }
    else if (type == MessageType::Console) {
        if (message.size() == 0) return;

        auto msg = ClearColors(message);
        auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);

        engine->ClientPrintf(CPlayerSlot(m_iPlayerId), msg.c_str());
    }
    else {
        auto msg = RemoveHtmlTags(message);
        if (msg.size() > 0) {
            if (msg.ends_with("\n")) msg.pop_back();

            msg += "\x01";

            bool startsWithColor = (msg.at(0) == '{');
            auto schema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);

            msg = ProcessColor(message, *(int*)(schema->GetPropPtr(GetController(), CBaseEntity_m_iTeamNum)));

            if (startsWithColor) msg = " " + msg;
        }

        auto networkMessages = g_ifaceService.FetchInterface<INetworkMessages>(NETWORKMESSAGES_INTERFACE_VERSION);
        auto gameEventSystem = g_ifaceService.FetchInterface<IGameEventSystem>(GAMEEVENTSYSTEM_INTERFACE_VERSION);

        auto netmsg = networkMessages->FindNetworkMessagePartial("TextMsg");
        auto pmsg = netmsg->AllocateMessage()->ToPB<CUserMessageTextMsg>();

        pmsg->set_dest((int)type);
        pmsg->add_param(msg);

        CSingleRecipientFilter filter(m_iPlayerId);
        gameEventSystem->PostEventAbstract(-1, false, &filter, netmsg, pmsg, 0);

        // see in src/engine/convars/convars.cpp at the end of the file why i "love" this now
        delete pmsg;
    }
}

bool CPlayer::IsAuthorized()
{
    return m_bAuthorized;
}

bool CPlayer::IsFakeClient()
{
    auto schema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);
    return (*(uint32_t*)schema->GetPropPtr(GetController(), CBaseEntity_m_fFlags)) & Flags_t::FL_FAKECLIENT;
}

uint32_t CPlayer::GetConnectedTime()
{
    return std::chrono::duration_cast<std::chrono::seconds>(std::chrono::high_resolution_clock::now() - m_uConnectedTimeStart).count();
}

int CPlayer::GetSlot()
{
    return m_iPlayerId;
}

void CPlayer::SetUnauthorizedSteamID(uint64_t steamID)
{
    m_uUnauthorizedSteamID = steamID;
}

uint64_t CPlayer::GetUnauthorizedSteamID()
{
    if (IsFakeClient()) return 0;

    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);

    auto steamid = engine->GetClientSteamID(m_iPlayerId);
    if (!steamid) return m_uUnauthorizedSteamID;

    return steamid->ConvertToUint64();
}

uint64_t CPlayer::GetSteamID()
{
    auto config = g_ifaceService.FetchInterface<IConfiguration>(CONFIGURATION_INTERFACE_VERSION);
    auto s = std::get_if<std::string>(&config->GetValue("core.SteamAuth.Mode"));
    if (m_bAuthorized) {
        if (IsFakeClient()) return 0;

        auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);

        auto steamid = engine->GetClientSteamID(m_iPlayerId);
        if (!steamid) return 0;

        return steamid->ConvertToUint64();
    }
    else if (*s == "flexible") {
        return GetUnauthorizedSteamID();
    }
    else return 0;
}

void CPlayer::ChangeAuthorizationState(bool bAuthorized)
{
    m_bAuthorized = bAuthorized;
}

std::string& CPlayer::GetLanguage()
{
    return m_sLanguage;
}

void* CPlayer::GetController()
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    CEntityInstance* controller = entsystem->GetEntitySystem()->GetEntityInstance(CEntityIndex(m_iPlayerId + 1));
    return controller;
}

void* CPlayer::GetPawn()
{
    auto schema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);
    auto controller = GetController();
    if (!controller) return nullptr;

    auto pawn = schema->GetPropPtr(controller, CBasePlayerController_m_hPawn);
    if (!pawn) return nullptr;

    CHandle<CEntityInstance>& pawnHandle = *(CHandle<CEntityInstance>*)pawn;
    return pawnHandle.Get();
}

void* CPlayer::GetPlayerPawn()
{
    auto schema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);
    auto pawn = GetPawn();
    if (!pawn) return nullptr;

    auto playerPawn = schema->GetPropPtr(pawn, CCSPlayerController_m_hPlayerPawn);
    if (!playerPawn) return nullptr;

    CHandle<CEntityInstance>& playerPawnHandle = *(CHandle<CEntityInstance>*)playerPawn;
    return playerPawnHandle.Get();
}

ListenOverride& CPlayer::GetListenOverride(int targetid)
{
    return m_uListenMap[targetid];
}

VoiceFlagValue& CPlayer::GetVoiceFlags()
{
    return m_uVoiceFlags;
}

CPlayerBitVec& CPlayer::GetSelfMutes()
{
    return m_bvSelfMutes;
}

uint64_t& CPlayer::GetPressedButtons()
{
    return m_uPressedButtons;
}

void CPlayer::PerformCommand(const std::string& command)
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    engine->ClientCommand(CPlayerSlot(m_iPlayerId), command.c_str());
}

std::string CPlayer::GetIPAddress()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    auto pNetChan = engine->GetPlayerNetInfo(m_iPlayerId);

    return explode(pNetChan->GetAddress(), ":")[0];
}

void CPlayer::Kick(const std::string& sReason, ENetworkDisconnectionReason uReason)
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    engine->DisconnectClient(m_iPlayerId, uReason, sReason.c_str());
}

void CPlayer::Think()
{

}