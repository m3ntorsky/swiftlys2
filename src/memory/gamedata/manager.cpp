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

#include "manager.h"

#include "offsets.h"
#include "patches.h"
#include "signatures.h"

#include <public/eiface.h>
#include <api/interfaces/manager.h>
#include <api/shared/string.h>
#include <api/shared/plat.h>
#include <api/shared/files.h>

IGameDataOffsets* GameDataManager::GetOffsets()
{
    if (m_pOffsets == nullptr) m_pOffsets = new GameDataOffsets();
    return m_pOffsets;
}

IGameDataSignatures* GameDataManager::GetSignatures()
{
    if (m_pSignatures == nullptr) m_pSignatures = new GameDataSignatures();
    return m_pSignatures;
}

IGameDataPatches* GameDataManager::GetPatches()
{
    if (m_pPatches == nullptr) m_pPatches = new GameDataPatches();
    return m_pPatches;
}

DynLibUtils::CModule DetermineModuleByLibrary(std::string library) {
    if (library == "server")
        return DynLibUtils::CModule(g_ifaceService.FetchInterface<IServerGameDLL>(INTERFACEVERSION_SERVERGAMEDLL));
    else if (library == "engine2")
        return DynLibUtils::CModule(g_ifaceService.FetchInterface<IVEngineServer2>(INTERFACEVERSION_VENGINESERVER));
    else
        return DynLibUtils::CModule(library);
}

extern std::vector<uint8_t> HexToByte(const char* src, uint64_t& length);

void* FindSignature(std::string library, std::string pattern)
{
    std::string binPath = "";
    if (library == "server" || library == "matchmaking" || library == "client")
        binPath = std::string("bin/") + WIN_LINUX("win64", "linuxsteamrt64") + WIN_LINUX("/", "/lib") + library + WIN_LINUX(".dll", ".so");
    else
        binPath = std::string("../bin/") + WIN_LINUX("win64", "linuxsteamrt64") + WIN_LINUX("/", "/lib") + library + WIN_LINUX(".dll", ".so");

    auto libModule = DetermineModuleByLibrary(library);
    std::string binContent = Files::Read(binPath);
    if (binContent == "") return nullptr;

    uint64_t length = 0;
    auto bytes = HexToByte(pattern.c_str(), length);
    auto binBytes = explode(binContent, "");

    for (int i = 0; i < binBytes.size() - bytes.size(); i++) {
        bool found = true;
        for (int j = 0; j < bytes.size(); j++) {
            if (bytes[j] != (uint8_t)"\x2A" && (uint8_t)(binBytes[i + j].c_str()[0]) != bytes[j]) {
                found = false;
                break;
            }
        }

        if (found) {
            return libModule.GetModuleBase().Offset(i).RCast<void*>();
        }
    }

    return nullptr;
}