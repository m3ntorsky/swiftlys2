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

#include <api/server/players/manager.h>

#include <public/eiface.h>

#include "player.h"

#include "networkbasetypes.pb.h"

#include <steam/steam_api_common.h>
#include <steam/isteamuser.h>
#include <steam/steamclientpublic.h>

class CPlayerManager : public IPlayerManager
{
public:
    virtual void Initialize() override;
    virtual void Shutdown() override;

    virtual IPlayer* RegisterPlayer(int playerid) override;
    virtual void UnregisterPlayer(int playerid) override;

    virtual IPlayer* GetPlayer(int playerid) override;

    virtual bool IsPlayerOnline(int playerid) override;

    virtual int GetPlayerCount() override;
    virtual int GetPlayerCap() override;

    virtual void SendMsg(MessageType type, const std::string& message) override;

    virtual void SteamAPIServerActivated() override;

    bool ClientConnect(CPlayerSlot slot, const char* pszName, uint64 xuid, const char* pszNetworkID, bool unk1, CBufferString* pRejectReason);
    void OnClientConnected(CPlayerSlot slot, const char* pszName, uint64 xuid, const char* pszNetworkID, const char* pszAddress, bool bFakePlayer);
    void ClientDisconnect(CPlayerSlot slot, ENetworkDisconnectionReason reason, const char* pszName, uint64 xuid, const char* pszNetworkID);
    void OnClientPutInServer(CPlayerSlot slot, char const* pszName, int type, uint64 xuid);
    void GameFrame(bool simulate, bool first, bool last);

    void CheckTransmit(CCheckTransmitInfo** ppInfoList, int infoCount, CBitVec<16384>& unionTransmitEdicts, CBitVec<16384>&, const Entity2Networkable_t** pNetworkables, const uint16_t* pEntityIndicies, int nEntities);

    STEAM_GAMESERVER_CALLBACK_MANUAL(CPlayerManager, OnValidateAuthTicket, ValidateAuthTicketResponse_t, m_CallbackValidateAuthTicketResponse);
private:
    CPlayer** g_Players = nullptr;
};