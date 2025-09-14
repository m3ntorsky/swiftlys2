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

#include "voicemanager.h"

#include <core/bridge/metamod.h>

#include <api/interfaces/manager.h>

SH_DECL_EXTERN3(IVEngineServer2, SetClientListening, SH_NOATTRIB, 0, bool, CPlayerSlot, CPlayerSlot, bool);
SH_DECL_EXTERN2_void(IServerGameClients, ClientCommand, SH_NOATTRIB, 0, CPlayerSlot, const CCommand&);

#define CBaseEntity_m_iTeamNum 0x9DC483B8A5BFEFB3

IVFunctionHook* g_pClientListening = nullptr;

void CVoiceManager::Initialize()
{
    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    auto gameclients = g_ifaceService.FetchInterface<IServerGameClients>(INTERFACEVERSION_SERVERGAMECLIENTS);

    SH_ADD_HOOK_MEMFUNC(IVEngineServer2, SetClientListening, engine, this, &CVoiceManager::SetClientListening, false);
    SH_ADD_HOOK_MEMFUNC(IServerGameClients, ClientCommand, gameclients, this, &CVoiceManager::OnClientCommand, false);
}

void CVoiceManager::Shutdown()
{
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    auto gameclients = g_ifaceService.FetchInterface<IServerGameClients>(INTERFACEVERSION_SERVERGAMECLIENTS);

    SH_REMOVE_HOOK_MEMFUNC(IVEngineServer2, SetClientListening, engine, this, &CVoiceManager::SetClientListening, false);
    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, ClientCommand, gameclients, this, &CVoiceManager::OnClientCommand, false);
}

bool CVoiceManager::SetClientListening(CPlayerSlot iReceiver, CPlayerSlot iSender, bool bListen)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto sdkschema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);

    IPlayer* receiver = playermanager->GetPlayer(iReceiver.Get());
    if (!receiver)
        RETURN_META_VALUE(MRES_IGNORED, bListen);

    IPlayer* sender = playermanager->GetPlayer(iSender.Get());
    if (!sender)
        RETURN_META_VALUE(MRES_IGNORED, bListen);

    auto& listenOverride = receiver->GetListenOverride(iSender.Get());
    auto& senderFlags = sender->GetVoiceFlags();
    auto& receiverFlags = receiver->GetVoiceFlags();
    auto& selfmutes = receiver->GetSelfMutes();

    if (selfmutes.Get(iSender.Get()))
    {
        RETURN_META_VALUE_NEWPARAMS(MRES_IGNORED, bListen, &IVEngineServer2::SetClientListening, (iReceiver, iSender, false));
    }

    if (senderFlags & VoiceFlagValue::Speak_Muted)
    {
        RETURN_META_VALUE_NEWPARAMS(MRES_IGNORED, bListen, &IVEngineServer2::SetClientListening, (iReceiver, iSender, false));
    }

    if (listenOverride == ListenOverride::Listen_Mute)
    {
        RETURN_META_VALUE_NEWPARAMS(MRES_IGNORED, bListen, &IVEngineServer2::SetClientListening, (iReceiver, iSender, false));
    }
    else if (listenOverride == ListenOverride::Listen_Hear)
    {
        RETURN_META_VALUE_NEWPARAMS(MRES_IGNORED, bListen, &IVEngineServer2::SetClientListening, (iReceiver, iSender, true));
    }

    if ((senderFlags & VoiceFlagValue::Speak_All) || (receiverFlags & VoiceFlagValue::Speak_ListenAll))
    {
        RETURN_META_VALUE_NEWPARAMS(MRES_IGNORED, bListen, &IVEngineServer2::SetClientListening, (iReceiver, iSender, true));
    }

    if ((senderFlags & VoiceFlagValue::Speak_Team) || (receiverFlags & VoiceFlagValue::Speak_ListenTeam))
    {
        auto senderController = sender->GetController();
        auto receiverController = receiver->GetController();
        if (!senderController || !receiverController)
            RETURN_META_VALUE(MRES_IGNORED, bListen);

        RETURN_META_VALUE_NEWPARAMS(MRES_IGNORED, bListen, &IVEngineServer2::SetClientListening,
            (
                iReceiver,
                iSender,
                (*(int*)(sdkschema->GetPropPtr(senderController, CBaseEntity_m_iTeamNum))) == (*(int*)(sdkschema->GetPropPtr(receiverController, CBaseEntity_m_iTeamNum)))
                )
        );
    }

    RETURN_META_VALUE(MRES_IGNORED, bListen);
}

void CVoiceManager::OnClientCommand(CPlayerSlot slot, const CCommand& args)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    IPlayer* receiver = playermanager->GetPlayer(slot.Get());
    if (!receiver) RETURN_META(MRES_IGNORED);

    if (args.ArgC() > 1 && std::string(args.Arg(0)) == "vban")
    {
        uint32_t mask = 0;
        sscanf(args.Arg(1), "%x", &mask);
        auto& selfmutes = receiver->GetSelfMutes();
        selfmutes.SetDWord(0, mask);
    }
}

void CVoiceManager::SetClientListenOverride(int playerid, int targetid, ListenOverride override)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playermanager->GetPlayer(playerid);
    if (!player) return;

    auto& listenOverrider = player->GetListenOverride(targetid);
    listenOverrider = override;
}

ListenOverride CVoiceManager::GetClientListenOverride(int playerid, int targetid)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playermanager->GetPlayer(playerid);
    if (!player) return Listen_Default;

    auto& listenOverrider = player->GetListenOverride(targetid);
    return listenOverrider;
}

void CVoiceManager::SetClientVoiceFlags(int playerid, VoiceFlagValue flags)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playermanager->GetPlayer(playerid);
    if (!player) return;

    auto& voiceFlags = player->GetVoiceFlags();
    voiceFlags = flags;
}

VoiceFlagValue CVoiceManager::GetClientVoiceFlags(int playerid)
{
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto player = playermanager->GetPlayer(playerid);
    if (!player) return Speak_Normal;

    auto& voiceFlags = player->GetVoiceFlags();
    return voiceFlags;
}
