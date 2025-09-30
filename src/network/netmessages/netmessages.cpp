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

#include "netmessages.h"
#include <core/bridge/metamod.h>

#include <api/interfaces/manager.h>
#include <api/sdk/serversideclient.h>
#include <memory/gamedata/manager.h>

#include <api/shared/plat.h>

#include <map>

SH_DECL_EXTERN8_void(IGameEventSystem, PostEventAbstract, SH_NOATTRIB, 0, CSplitScreenSlot, bool, int, const uint64*, INetworkMessageInternal*, const CNetMessage*, unsigned long, NetChannelBufType_t)
SH_DECL_MANUALHOOK2(FilterMessage, 0, 0, 0, bool, CNetMessage*, INetChannel*);

std::map<uint64_t, std::function<int(uint64_t*, int, void*)>> g_mServerMessageSendCallbacks;
std::map<uint64_t, std::function<int(int, int, void*)>> g_mClientMessageSendCallbacks;

int g_ihookID = -1;

void CNetMessages::Initialize()
{
    auto gameeventsystem = g_ifaceService.FetchInterface<IGameEventSystem>(GAMEEVENTSYSTEM_INTERFACE_VERSION);

    SH_ADD_HOOK_MEMFUNC(IGameEventSystem, PostEventAbstract, gameeventsystem, this, &CNetMessages::PostEvent, false);

    DynLibUtils::CModule eng = DetermineModuleByLibrary("engine2");
    void* prefilterVTable = FindVirtTable(&eng, "CServerSideClient", WIN_LINUX(8, -64));

    g_ihookID = SH_ADD_MANUALDVPHOOK(FilterMessage, (INetworkMessageProcessingPreFilterCustom*)prefilterVTable, SH_MEMBER(this, &CNetMessages::FilterMessage), false);
}

void CNetMessages::Shutdown()
{
    auto gameeventsystem = g_ifaceService.FetchInterface<IGameEventSystem>(GAMEEVENTSYSTEM_INTERFACE_VERSION);

    SH_REMOVE_HOOK_MEMFUNC(IGameEventSystem, PostEventAbstract, gameeventsystem, this, &CNetMessages::PostEvent, false);

    SH_REMOVE_HOOK_ID(g_ihookID);
    g_ihookID = -1;
}

bool CNetMessages::FilterMessage(CNetMessage* cMsg, INetChannel* netchan)
{
    auto client = META_IFACEPTR(INetworkMessageProcessingPreFilterCustom);
    if (!client) RETURN_META_VALUE(MRES_IGNORED, true);
    if (!cMsg) RETURN_META_VALUE(MRES_IGNORED, true);

    auto playerid = client->GetPlayerSlot().Get();
    int msgid = cMsg->GetNetMessage()->GetNetMessageInfo()->m_MessageId;

    for (const auto& [id, callback] : g_mClientMessageSendCallbacks) {
        auto res = callback(playerid, msgid, cMsg);
        if (res == 1) RETURN_META_VALUE(MRES_SUPERCEDE, true);
        else if (res == 2) break;
    }

    RETURN_META_VALUE(MRES_IGNORED, true);
}

void CNetMessages::PostEvent(CSplitScreenSlot nSlot, bool bLocalOnly, int nClientCount, const uint64* clients, INetworkMessageInternal* pEvent, const CNetMessage* pData, unsigned long nSize, NetChannelBufType_t bufType)
{
    int msgid = pEvent->GetNetMessageInfo()->m_MessageId;
    CNetMessage* msg = const_cast<CNetMessage*>(pData);
    uint64_t* playermask = (uint64_t*)(clients);

    for (const auto& [id, callback] : g_mServerMessageSendCallbacks) {
        auto res = callback(playermask, msgid, msg);
        if (res == 1) RETURN_META(MRES_SUPERCEDE);
        else if (res == 2) break;
    }

    RETURN_META(MRES_IGNORED);
}

uint64_t CNetMessages::AddServerMessageSendCallback(std::function<int(uint64_t*, int, void*)> callback)
{
    static uint64_t s_CallbackID = 0;
    g_mServerMessageSendCallbacks[s_CallbackID++] = callback;
    return s_CallbackID - 1;
}

void CNetMessages::RemoveServerMessageSendCallback(uint64_t callbackID)
{
    g_mServerMessageSendCallbacks.erase(callbackID);
}

uint64_t CNetMessages::AddClientMessageSendCallback(std::function<int(int, int, void*)> callback)
{
    static uint64_t s_CallbackID = 0;
    g_mClientMessageSendCallbacks[s_CallbackID++] = callback;
    return s_CallbackID - 1;
}

void CNetMessages::RemoveClientMessageSendCallback(uint64_t callbackID)
{
    g_mClientMessageSendCallbacks.erase(callbackID);
}