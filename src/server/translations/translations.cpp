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

#include "translations.h"

#include <api/interfaces/manager.h>

#include <api/shared/files.h>
#include <api/shared/jsonc.h>
#include <api/shared/plat.h>
#include <api/shared/string.h>

#include <nlohmann/json.hpp>

using json = nlohmann::json;

static std::map<std::string, std::string> l_mLanguages = {
    { "arabic", "ar" },
    { "bulgarian", "bg" },
    { "schinese", "zh-CN" },
    { "tchinese", "zh-TW" },
    { "czech", "cs" },
    { "danish", "da" },
    { "dutch", "nl" },
    { "english", "en" },
    { "finnish", "fi" },
    { "french", "fr" },
    { "german", "de" },
    { "greek", "el" },
    { "hungarian", "hu" },
    { "indonesian", "id" },
    { "italian", "it" },
    { "japanese", "ja" },
    { "koreana", "ko" },
    { "norwegian", "no" },
    { "polish", "pl" },
    { "portuguese", "pt" },
    { "brazilian", "pt-BR" },
    { "romanian", "ro" },
    { "russian", "ru" },
    { "spanish", "es" },
    { "latam", "es-419" },
    { "swedish", "sv" },
    { "thai", "th" },
    { "turkish", "tr" },
    { "ukrainian", "uk" },
    { "vietnamese", "vn" },
};

void CTranslations::Initialize()
{
    auto cvarmanager = g_ifaceService.FetchInterface<IConvarManager>(CONVARMANAGER_INTERFACE_VERSION);

    cvarmanager->AddQueryClientCvarCallback([](int playerid, std::string cvar_name, std::string cvar_value) {
        if (cvar_name != "cl_language") return;

        auto configuration = g_ifaceService.FetchInterface<IConfiguration>(CONFIGURATION_INTERFACE_VERSION);
        auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
        auto player = playermanager->GetPlayer(playerid);
        if (!player) return;

        auto it = l_mLanguages.find(cvar_value);
        if (it != l_mLanguages.end())
            player->GetLanguage() = it->second;
        else
            player->GetLanguage() = std::get<std::string>(configuration->GetValue("core.Language"));
    });

    LoadTranslations();
}

void CTranslations::ClearTranslations()
{
    m_mTranslations.clear();
}

void CTranslations::LoadTranslations()
{
    ClearTranslations();

    if (!Files::ExistsPath("addons/swiftly/translations"))
        Files::CreateDir("addons/swiftly/translations");

    std::vector<std::string> translationFiles = Files::FetchFileNames("addons/swiftly/translations");

    for (const std::string& translationFilePath : translationFiles)
    {
        if (!ends_with(translationFilePath, ".jsonc"))
            continue;

        if (!starts_with(translationFilePath, std::format("addons/swiftly/translations{}translation.", WIN_LINUX("\\", "/"))))
            continue;

        LoadTranslationFile(translationFilePath);
    }
}

void CTranslations::LoadTranslationFile(const std::string& file)
{
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    std::string translationFileName = explode(file, std::format("addons/swiftly/translations{}", WIN_LINUX("\\", "/")))[1];
    std::string mainTranslationKey = explode(explode(translationFileName, ".json")[0], "translation.")[1];

    auto j = parseJsonc(Files::Read(file));
    if (!j.is_object()) {
        logger->Error("Translations", std::format("The file {} is not a valid JSON object.\n", file));
        return;
    }

    for (auto it = j.begin(); it != j.end(); ++it) {
        if (!it.value().is_object()) {
            logger->Error("Translations", std::format("The key '{}' in the file '{}' is not a valid JSON object.\n", it.key(), file));
            continue;
        }

        for (auto it2 = it.value().begin(); it2 != it.value().end(); ++it2) {
            m_mTranslations[mainTranslationKey + "." + it.key()][it2.key()] = it2.value();
        }
    }

    logger->Info("Translations", std::format("Loaded translation file '{}' with {} entries.\n", file, m_mTranslations.size()));
}

std::string CTranslations::FetchTranslation(const std::string& key, int playerid)
{
    auto it = m_mTranslations.find(key);
    if (it == m_mTranslations.end()) return key;

    auto configuration = g_ifaceService.FetchInterface<IConfiguration>(CONFIGURATION_INTERFACE_VERSION);

    auto language = std::get<std::string>(configuration->GetValue("core.Language"));

    if (playerid > -1) {
        if (std::get<bool>(configuration->GetValue("core.UsePlayerLanguage"))) {
            auto playermanager = g_ifaceService.FetchInterface<IPlayerManager>(PLAYERMANAGER_INTERFACE_VERSION);
            auto player = playermanager->GetPlayer(playerid);
            if (player) language = player->GetLanguage();
        }
    }

    auto it2 = it->second.find(language);
    if (it2 != it->second.end()) return it2->second;

    return key + "." + language;
}