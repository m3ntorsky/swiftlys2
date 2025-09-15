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

int Bridge_Translations_Fetch(char* cout, const char* key, int playerid)
{
    auto translations = g_ifaceService.FetchInterface<ITranslations>(TRANSLATIONS_INTERFACE_VERSION);
    static std::string translation;
    translation = translations->FetchTranslation(key, playerid);

    if (cout != nullptr) strcpy(cout, translation.c_str());

    return translation.size();
}

DEFINE_NATIVE("Translations.Fetch", Bridge_Translations_Fetch);