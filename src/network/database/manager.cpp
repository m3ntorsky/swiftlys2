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

#include <api/shared/files.h>
#include <api/shared/jsonc.h>

#include <api/interfaces/manager.h>

#include <nlohmann/json.hpp>

using json = nlohmann::json;

void CDatabaseManager::Initialize()
{
    std::string file_path = "addons/swiftly/configs/database.jsonc";
    json j = parseJsonc(Files::Read(file_path));

    m_sDefaultConnection = j["default_connection"].get<std::string>();
    for (auto& [key, value] : j["connections"].items())
    {
        m_mConnectionCredentials[key] = value.get<std::string>();
    }

    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    logger->Info("Database Manager", std::format("Loaded {} database credentials. (Default Connection: {})", m_mConnectionCredentials.size(), m_sDefaultConnection));
}

std::string CDatabaseManager::GetDefaultConnection()
{
    return m_sDefaultConnection;
}

std::string CDatabaseManager::GetDefaultConnectionCredentials()
{
    return GetCredentials(m_sDefaultConnection);
}

std::string CDatabaseManager::GetCredentials(const std::string& connectionName)
{
    auto it = m_mConnectionCredentials.find(connectionName);
    if (it != m_mConnectionCredentials.end()) return it->second;
    else return "";
}

bool CDatabaseManager::ConnectionExists(const std::string& connectionName)
{
    return m_mConnectionCredentials.contains(connectionName);
}
