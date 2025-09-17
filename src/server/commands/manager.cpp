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

#include <public/icvar.h>

std::map<std::string, ConCommand*> conCommandCreated;
std::map<uint64_t, std::string> conCommandMapping;

SH_DECL_EXTERN3_void(ICvar, DispatchConCommand, SH_NOATTRIB, 0, ConCommandRef, const CCommandContext&, const CCommand&);

void CServerCommands::Initialize()
{
    auto cvar = g_ifaceService.FetchInterface<ICvar>(CVAR_INTERFACE_VERSION);
    SH_ADD_HOOK_MEMFUNC(ICvar, DispatchConCommand, cvar, this, &CServerCommands::DispatchConCommand, false);
}

void CServerCommands::Shutdown()
{
    auto cvar = g_ifaceService.FetchInterface<ICvar>(CVAR_INTERFACE_VERSION);
    SH_REMOVE_HOOK_MEMFUNC(ICvar, DispatchConCommand, cvar, this, &CServerCommands::DispatchConCommand, false);
}

// @returns 1 - command is not silent
// @returns 2 - command is silent
// @returns -1 - invalid controller
// @returns 0 - is not command
int CServerCommands::HandleCommand(int playerid, const std::string& text)
{
    return 0;
}

bool CServerCommands::HandleClientCommand(int playerid, const std::string& text)
{
    return false;
}

bool CServerCommands::HandleClientChat(int playerid, const std::string& text, bool teamonly)
{
    return false;
}

uint64_t CServerCommands::RegisterCommand(std::string command_name, std::function<void(int, std::vector<std::string>, std::string, std::string, bool)> handler)
{
    return 0;
}

void CServerCommands::UnregisterCommand(uint64_t command_id)
{
}

uint64_t CServerCommands::RegisterClientCommandsListener(std::function<bool(int, const std::string&)> listener)
{
    return 0;
}

void CServerCommands::UnregisterClientCommandsListener(uint64_t listener_id)
{

}

uint64_t CServerCommands::RegisterClientChatListener(std::function<bool(int, const std::string&, bool)> listener)
{
    return 0;
}

void CServerCommands::UnregisterClientChatListener(uint64_t listener_id)
{

}

void CServerCommands::DispatchConCommand(ConCommandRef cmd, const CCommandContext& ctx, const CCommand& args)
{
    CPlayerSlot slot = ctx.GetPlayerSlot();
    auto servercommands = g_ifaceService.FetchInterface<IServerCommands>(SERVERCOMMANDS_INTERFACE_VERSION);
    auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
    auto eventmanager = g_ifaceService.FetchInterface<IEventManager>(GAMEEVENTMANAGER_INTERFACE_VERSION);

    if (slot.Get() != -1)
    {
        if (!servercommands->HandleClientCommand(slot.Get(), args.GetCommandString())) RETURN_META(MRES_SUPERCEDE);

        std::string command = args.Arg(0);
        if (command == "say" || command == "say_team")
        {
            auto player = playermanager->GetPlayer(slot.Get());
            if (!player) return;

            void* controller = player->GetController();
            bool teamonly = (command == "say_team");

            auto text = args[1];
            if (strlen(text) == 0) RETURN_META(MRES_SUPERCEDE);

            if (controller)
            {
                IGameEvent* pEvent = eventmanager->GetGameEventManager()->CreateEvent("player_chat");

                if (pEvent)
                {
                    pEvent->SetBool("teamonly", teamonly);
                    pEvent->SetInt("userid", slot.Get());
                    pEvent->SetString("text", text);

                    eventmanager->GetGameEventManager()->FireEvent(pEvent, true);
                }
            }

            int handleCommandReturn = servercommands->HandleCommand(slot.Get(), args.GetCommandString());
            if (handleCommandReturn == 2 || !servercommands->HandleClientChat(slot.Get(), text, teamonly)) RETURN_META(MRES_SUPERCEDE);
        }
    }
}