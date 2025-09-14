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

#include <scripting/scripting.h>
#include <api/interfaces/manager.h>

int Bridge_Database_GetDefaultConnection(char* out)
{
    auto db = g_ifaceService.FetchInterface<IDatabaseManager>(DATABASEMANAGER_INTERFACE_VERSION);
    static std::string o;
    o = db->GetDefaultConnection();

    if (out != nullptr) {
        strcpy(out, o.c_str());
    }

    return o.size();
}

int Bridge_Database_GetDefaultConnectionCredentials(char* out)
{
    auto db = g_ifaceService.FetchInterface<IDatabaseManager>(DATABASEMANAGER_INTERFACE_VERSION);
    static std::string o;
    o = db->GetDefaultConnectionCredentials();

    if (out != nullptr) {
        strcpy(out, o.c_str());
    }

    return o.size();
}

int Bridge_Database_GetCredentials(char* out, const char* connectionName)
{
    auto db = g_ifaceService.FetchInterface<IDatabaseManager>(DATABASEMANAGER_INTERFACE_VERSION);
    static std::string o;
    o = db->GetCredentials(connectionName);

    if (out != nullptr) {
        strcpy(out, o.c_str());
    }

    return o.size();
}

bool Bridge_Database_ConnectionExists(const char* connectionName)
{
    auto db = g_ifaceService.FetchInterface<IDatabaseManager>(DATABASEMANAGER_INTERFACE_VERSION);
    return db->ConnectionExists(connectionName);
}

DEFINE_NATIVE("Database.GetDefaultConnection", Bridge_Database_GetDefaultConnection);
DEFINE_NATIVE("Database.GetDefaultConnectionCredentials", Bridge_Database_GetDefaultConnectionCredentials);
DEFINE_NATIVE("Database.GetCredentials", Bridge_Database_GetCredentials);
DEFINE_NATIVE("Database.ConnectionExists", Bridge_Database_ConnectionExists);