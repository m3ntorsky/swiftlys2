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

#include <api/interfaces/interfaces.h>
#include <core/entrypoint.h>

#include <core/extensions/manager.h>

#include <engine/convars/convars.h>
#include <engine/entities/entitysystem.h>
#include <engine/gameevents/gameevents.h>
#include <engine/precacher/precacher.h>
#include <engine/vgui/vgui.h>
#include <engine/voicemanager/voicemanager.h>

#include <memory/allocator/allocator.h>
#include <memory/hooks/manager.h>
#include <memory/gamedata/manager.h>

#include <monitor/logger/logger.h>
#include <monitor/crashreporter/crashreporter.h>

#include <network/sounds/soundevents.h>
#include <network/database/manager.h>
#include <network/netmessages/netmessages.h>

#include <scripting/scripting.h>

#include <sdk/schema.h>

#include <server/commands/manager.h>
#include <server/configuration/configuration.h>
#include <server/players/manager.h>
#include <server/translations/translations.h>

#include <map>

ExtensionManager g_ExtensionsManager;
Logger g_Logger;
MemoryAllocator g_MemoryAllocator;
CrashReporter g_CrashReporter;
HooksManager g_HooksManager;
GameDataManager g_GameDataManager;
Configuration g_Configuration;
CEntSystem g_EntSystem;
CSDKSchema g_SDKSchema;
CConvarManager g_ConvarManager;
CEventManager g_GameEventManager;
CPrecacher g_Precacher;
CScriptingAPI g_ScriptingAPI;
CPlayerManager g_PlayerManager;
CVoiceManager g_VoiceManager;
CSoundEventManager g_SoundEventManager;
CDatabaseManager g_DatabaseManager;
CTranslations g_Translations;
CServerCommands g_ServerCommands;
CNetMessages g_NetMessages;
CVGUI g_VGUI;

static const std::map<std::string, void*> g_Interfaces = {
    {EXTENSIONMANAGER_INTERFACE_VERSION, &g_ExtensionsManager},
    {LOGGER_INTERFACE_VERSION, &g_Logger},
    {MEMORYALLOCATOR_INTERFACE_VERSION, &g_MemoryAllocator},
    {CRASHREPORTER_INTERFACE_VERSION, &g_CrashReporter},
    {HOOKSMANAGER_INTERFACE_VERSION, &g_HooksManager},
    {GAMEDATA_INTERFACE_VERSION, &g_GameDataManager},
    {CONFIGURATION_INTERFACE_VERSION, &g_Configuration},
    {ENTITYSYSTEM_INTERFACE_VERSION, &g_EntSystem},
    {SDKSCHEMA_INTERFACE_VERSION, &g_SDKSchema},
    {CONVARMANAGER_INTERFACE_VERSION, &g_ConvarManager},
    {GAMEEVENTMANAGER_INTERFACE_VERSION, &g_GameEventManager},
    {PRECACHER_INTERFACE_VERSION, &g_Precacher},
    {SCRIPTING_INTERFACE_VERSION, &g_ScriptingAPI},
    {PLAYERMANAGER_INTERFACE_VERSION, &g_PlayerManager},
    {VOICEMANAGER_INTERFACE_VERSION, &g_VoiceManager},
    {SOUNDEVENTMANAGER_INTERFACE_VERSION, &g_SoundEventManager},
    {DATABASEMANAGER_INTERFACE_VERSION, &g_DatabaseManager},
    {TRANSLATIONS_INTERFACE_VERSION, &g_Translations},
    {SERVERCOMMANDS_INTERFACE_VERSION, &g_ServerCommands},
    {NETMESSAGES_INTERFACE_VERSION, &g_NetMessages},
    {VGUI_INTERFACE_VERSION, &g_VGUI},
};

SW_API void* GetPureInterface(const char* iface_name)
{
    auto it = g_Interfaces.find(iface_name);
    if (it != g_Interfaces.end()) return it->second;

    return g_SwiftlyCore.GetInterface(iface_name);
}