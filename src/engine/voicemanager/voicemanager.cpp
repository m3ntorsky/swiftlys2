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

#include <api/interfaces/manager.h>

IVFunctionHook* g_pClientListening = nullptr;

void CVoiceManager::Initialize()
{
    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);
    auto engine = g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER);
    auto gameclients = g_ifaceService.FetchInterface<IServerGameClients>(INTERFACEVERSION_SERVERGAMECLIENTS);

    g_pClientListening = hooksmanager->CreateVFunctionHook();
    g_pClientListening->SetHookFunction(engine, GetVirtualFunctionId(&IVEngineServer2::SetClientListening), "piib", 'b', false);

    g_pClientListening->SetCallback(dyno::CallbackType::Pre, [](dyno::CallbackType type, dyno::IHook& hook) -> dyno::ReturnAction {
        return dyno::ReturnAction::Ignored;
    });
}

void CVoiceManager::Shutdown()
{
}

void CVoiceManager::SetClientListenOverride(int playerid, int targetid, ListenOverride override)
{
}

void CVoiceManager::ResetClientListenOverride(int playerid)
{
}

ListenOverride CVoiceManager::GetClientListenOverride(int playerid, int targetid)
{
    return Listen_Default;
}

void CVoiceManager::SetClientVoiceFlags(int playerid, VoiceFlagValue flags)
{
}

void CVoiceManager::ResetClientVoiceFlags(int playerid)
{
}

VoiceFlagValue CVoiceManager::GetClientVoiceFlags(int playerid)
{
    return Speak_Normal;
}
