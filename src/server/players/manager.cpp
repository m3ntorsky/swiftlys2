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

#include "cs_usercmd.pb.h"
#include "usercmd.pb.h"

class EntityCheckTransmit
{
public:
    CBitVec<MAX_EDICTS>* m_pTransmitEntity;	// 0
    CBitVec<MAX_EDICTS>* m_pUnkBitVec;		// 8
    CBitVec<MAX_EDICTS>* m_pUnkBitVec2;		// 16
    CBitVec<MAX_EDICTS>* m_pUnkBitVec3;		// 24
    CBitVec<MAX_EDICTS>* m_pTransmitAlways; // 32
    CUtlVector<int> m_unk40;				// 40
    vis_info_t* m_VisInfo;					// 64
    [[maybe_unused]] byte m_unk72[0x1F8];	// 72
    CEntityIndex m_nClientEntityIndex;		// 576
    bool m_bFullUpdate;						// 580
};

class CUserCmd
{
public:
    [[maybe_unused]] char pad0[0x10];
    CSGOUserCmdPB cmd;
    [[maybe_unused]] char pad1[0x38];
#ifdef _WIN32
    [[maybe_unused]] char pad2[0x8];
#endif
};

SH_DECL_EXTERN3_void(IServerGameDLL, GameFrame, SH_NOATTRIB, 0, bool, bool, bool);
SH_DECL_EXTERN4_void(IServerGameClients, ClientPutInServer, SH_NOATTRIB, 0, CPlayerSlot, char const*, int, uint64);
SH_DECL_EXTERN5_void(IServerGameClients, ClientDisconnect, SH_NOATTRIB, 0, CPlayerSlot, ENetworkDisconnectionReason, const char*, uint64, const char*);
SH_DECL_EXTERN6(IServerGameClients, ClientConnect, SH_NOATTRIB, 0, bool, CPlayerSlot, const char*, uint64, const char*, bool, CBufferString*);
SH_DECL_EXTERN6_void(IServerGameClients, OnClientConnected, SH_NOATTRIB, 0, CPlayerSlot, const char*, uint64, const char*, const char*, bool);
SH_DECL_EXTERN7_void(ISource2GameEntities, CheckTransmit, SH_NOATTRIB, 0, CCheckTransmitInfo**, int, CBitVec<16384>&, CBitVec<16384>&, const Entity2Networkable_t**, const uint16_t*, int);

uint64_t playerMask = 0;
IFunctionHook* g_pProcessUserCmdsHook = nullptr;

void* ProcessUsercmdsHook(void* pController, CUserCmd* cmds, int numcmds, bool paused, float margin);

void CPlayerManager::Initialize()
{
    g_Players = new CPlayer * [g_SwiftlyCore.GetMaxGameClients()];
    for (int i = 0; i < g_SwiftlyCore.GetMaxGameClients(); i++) {
        g_Players[i] = nullptr;
    }

    auto gameclients = g_ifaceService.FetchInterface<IServerGameClients>(INTERFACEVERSION_SERVERGAMECLIENTS);
    auto server = g_ifaceService.FetchInterface<IServerGameDLL>(INTERFACEVERSION_SERVERGAMEDLL);
    auto gameentities = g_ifaceService.FetchInterface<ISource2GameEntities>(SOURCE2GAMEENTITIES_INTERFACE_VERSION);

    SH_ADD_HOOK_MEMFUNC(IServerGameClients, ClientConnect, gameclients, this, &CPlayerManager::ClientConnect, false);
    SH_ADD_HOOK_MEMFUNC(IServerGameClients, OnClientConnected, gameclients, this, &CPlayerManager::OnClientConnected, false);
    SH_ADD_HOOK_MEMFUNC(IServerGameClients, ClientDisconnect, gameclients, this, &CPlayerManager::ClientDisconnect, true);
    SH_ADD_HOOK_MEMFUNC(IServerGameClients, ClientPutInServer, gameclients, this, &CPlayerManager::OnClientPutInServer, true);
    SH_ADD_HOOK_MEMFUNC(IServerGameDLL, GameFrame, server, this, &CPlayerManager::GameFrame, true);
    SH_ADD_HOOK_MEMFUNC(ISource2GameEntities, CheckTransmit, gameentities, this, &CPlayerManager::CheckTransmit, true);

    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);
    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);

    auto processusercmds = gamedata->GetSignatures()->Fetch("CCSPlayerController::ProcessUserCmd");
    g_pProcessUserCmdsHook = hooksmanager->CreateFunctionHook();

    g_pProcessUserCmdsHook->SetHookFunction(processusercmds, reinterpret_cast<void*>(ProcessUsercmdsHook));
    g_pProcessUserCmdsHook->Enable();
}

void CPlayerManager::Shutdown() {
    for (int i = 0; i < g_SwiftlyCore.GetMaxGameClients(); i++) {
        if (g_Players[i] != nullptr) {
            delete g_Players[i];
        }
    }
    delete[] g_Players;

    auto gameclients = g_ifaceService.FetchInterface<IServerGameClients>(INTERFACEVERSION_SERVERGAMECLIENTS);
    auto server = g_ifaceService.FetchInterface<IServerGameDLL>(INTERFACEVERSION_SERVERGAMEDLL);
    auto gameentities = g_ifaceService.FetchInterface<ISource2GameEntities>(SOURCE2GAMEENTITIES_INTERFACE_VERSION);

    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, ClientConnect, gameclients, this, &CPlayerManager::ClientConnect, false);
    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, OnClientConnected, gameclients, this, &CPlayerManager::OnClientConnected, false);
    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, ClientDisconnect, gameclients, this, &CPlayerManager::ClientDisconnect, true);
    SH_REMOVE_HOOK_MEMFUNC(IServerGameClients, ClientPutInServer, gameclients, this, &CPlayerManager::OnClientPutInServer, true);
    SH_REMOVE_HOOK_MEMFUNC(IServerGameDLL, GameFrame, server, this, &CPlayerManager::GameFrame, true);
    SH_REMOVE_HOOK_MEMFUNC(ISource2GameEntities, CheckTransmit, gameentities, this, &CPlayerManager::CheckTransmit, true);

    g_pProcessUserCmdsHook->Disable();
    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);
    hooksmanager->DestroyFunctionHook(g_pProcessUserCmdsHook);
    g_pProcessUserCmdsHook = nullptr;
}

extern void* g_pOnClientPutInServerCallback;

void CPlayerManager::OnClientPutInServer(CPlayerSlot slot, char const* pszName, int type, uint64 xuid)
{
    if (g_pOnClientPutInServerCallback)
        reinterpret_cast<void(*)(int, int)>(g_pOnClientPutInServerCallback)(slot.Get(), type);
}

extern void* g_pOnClientProcessUsercmdsCallback;

void* ProcessUsercmdsHook(void* pController, CUserCmd* cmds, int numcmds, bool paused, float margin)
{
    auto playerid = ((CEntityInstance*)pController)->m_pEntity->m_EHandle.GetEntryIndex() - 1;

    google::protobuf::Message** pMsg = new google::protobuf::Message * [numcmds];
    for (int i = 0; i < numcmds; i++)
        pMsg[i] = (google::protobuf::Message*)&cmds[i].cmd;

    if (g_pOnClientProcessUsercmdsCallback)
        reinterpret_cast<void(*)(int, void*, int, bool, float)>(g_pOnClientProcessUsercmdsCallback)(playerid, pMsg, numcmds, paused, margin);

    delete[] pMsg;

    return reinterpret_cast<void* (*)(void*, CUserCmd*, int, bool, float)>(g_pProcessUserCmdsHook->GetOriginal())(pController, cmds, numcmds, paused, margin);
}

void CPlayerManager::CheckTransmit(CCheckTransmitInfo** ppInfoList, int infoCount, CBitVec<16384>& unionTransmitEdicts, CBitVec<16384>&, const Entity2Networkable_t** pNetworkables, const uint16_t* pEntityIndicies, int nEntities)
{
    static auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    for (int i = 0; i < infoCount; i++)
    {
        auto& pInfo = (EntityCheckTransmit*&)ppInfoList[i];
        int playerid = pInfo->m_nClientEntityIndex.Get();
        if ((playerMask & (1ULL << playerid)) == 0) continue;
        auto player = playermanager->GetPlayer(playerid);

        auto& blockedBits = player->GetBlockedTransmittingBits();

        uint32_t* base = pInfo->m_pTransmitEntity->Base();
        uint32_t* baseAlways = pInfo->m_pTransmitAlways->Base();
        auto& activeMasks = blockedBits.activeMasks;

        // NUM_MASKS_ACTIVE ops = NUM_MASKS_ACTIVE*32 bits -> 64 players -> NUM_MASKS_ACTIVE*64 ops
        for (auto& dword : activeMasks) {
            base[dword] &= ~blockedBits.blockedMask[dword];
            baseAlways[dword] &= ~blockedBits.blockedMask[dword];
        }

        // 512 ops = 16k bits -> 64 players -> 32k ops
        // for (int i = pInfo->m_pTransmitEntity->GetNumDWords() - 1; i >= 0; i--) {
        //     uint32_t& word = base[i];
        //     uint32_t& wordAlways = baseAlways[i];

        //     word &= ~blockedBase[i];
        //     wordAlways &= ~blockedBase[i];
        // }

        //16k ops = 16k bits -> 64 players -> 1M ops
        /*
        for (int i = 0; i < 16384; i++)
            if (blockedBits.IsBitSet(i))
                pInfo->m_pTransmitEntity->Clear(i);
        */
    }
}

extern void* g_pOnGameTickCallback;

void CPlayerManager::GameFrame(bool simulate, bool first, bool last)
{
    static auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    static auto vgui = g_ifaceService.FetchInterface<IVGUI>(VGUI_INTERFACE_VERSION);

    if (g_pOnGameTickCallback) reinterpret_cast<void(*)(bool, bool, bool)>(g_pOnGameTickCallback)(simulate, first, last);

    for (int i = 0; i < 64; i++)
        if (playerMask & (1ULL << i))
            playermanager->GetPlayer(i)->Think();

    vgui->Update();
}

extern void* g_pOnClientConnectCallback;

bool CPlayerManager::ClientConnect(CPlayerSlot slot, const char* pszName, uint64 xuid, const char* pszNetworkID, bool unk1, CBufferString* pRejectReason)
{
    static auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto playerid = slot.Get();
    auto player = playermanager->RegisterPlayer(playerid);
    player->Initialize(playerid);
    player->SetUnauthorizedSteamID(xuid);

    if (g_pOnClientConnectCallback)
        if (reinterpret_cast<bool(*)(int)>(g_pOnClientConnectCallback)(playerid) == false)
            RETURN_META_VALUE(MRES_SUPERCEDE, false);

    RETURN_META_VALUE(MRES_IGNORED, true);
}

void CPlayerManager::OnClientConnected(CPlayerSlot slot, const char* pszName, uint64 xuid, const char* pszNetworkID, const char* pszAddress, bool bFakePlayer)
{
    static auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
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

extern void* g_pOnClientDisconnectCallback;

void CPlayerManager::ClientDisconnect(CPlayerSlot slot, ENetworkDisconnectionReason reason, const char* pszName, uint64 xuid, const char* pszNetworkID)
{
    static auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto playerid = slot.Get();

    if (g_pOnClientDisconnectCallback)
        reinterpret_cast<void(*)(int, int)>(g_pOnClientDisconnectCallback)(playerid, reason);

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

    static auto vgui = g_ifaceService.FetchInterface<IVGUI>(VGUI_INTERFACE_VERSION);

    vgui->UnregisterForPlayer(g_Players[playerid]);

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