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

#include <api/interfaces/manager.h>
#include <core/entrypoint.h>
#include <core/bridge/metamod.h>

#include <public/tier0/platform.h>
#include <public/steam/isteamgameserver.h>

#include "serverlist.h"

SH_DECL_EXTERN3_void(IServerGameDLL, GameFrame, SH_NOATTRIB, 0, bool, bool, bool);

void ServerListFix::Start()
{
    auto server = g_ifaceService.FetchInterface<IServerGameDLL>(INTERFACEVERSION_SERVERGAMEDLL);

    SH_ADD_HOOK_MEMFUNC(IServerGameDLL, GameFrame, server, this, &ServerListFix::GameFrame, true);
}

void ServerListFix::Stop()
{
    auto server = g_ifaceService.FetchInterface<IServerGameDLL>(INTERFACEVERSION_SERVERGAMEDLL);

    SH_REMOVE_HOOK_MEMFUNC(IServerGameDLL, GameFrame, server, this, &ServerListFix::GameFrame, true);
}

void ServerListFix::GameFrame(bool simulate, bool first, bool last)
{
    static double l_NextUpdate = 0.0;

    if (double curtime = Plat_FloatTime(); curtime >= l_NextUpdate)
    {
        l_NextUpdate = curtime + 5.0;

        auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
        auto gameclients = g_ifaceService.FetchInterface<ISource2GameClients>(INTERFACEVERSION_SERVERGAMECLIENTS);

        auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
        auto schema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);

        for (int i = 0; i < playermanager->GetPlayerCap(); i++)
        {
            auto steamid = engine->GetClientSteamID(i);
            if (!steamid) continue;

            auto player = playermanager->GetPlayer(i);
            if (!player) continue;

            auto controller = player->GetController();
            if (!controller) continue;

            g_SteamAPI.SteamGameServer()->BUpdateUserData(*steamid, (const char*)(schema->GetPropPtr(controller, 4141622183986322747)), gameclients->GetPlayerScore(i)); // CBasePlayerController::PlayerName
        }
    }
}