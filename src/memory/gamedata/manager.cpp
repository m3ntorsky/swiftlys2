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
#include <api/shared/files.h>
#include <api/shared/plat.h>

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
    if (library == "server" || library == "client" || library == "matchmaking")
        return DynLibUtils::CModule(GeneratePath(std::string("bin/") + WIN_LINUX("win64", "linuxsteamrt64") + "/" + library + WIN_LINUX(".dll", ".so")));
    else
        return DynLibUtils::CModule(GeneratePath(std::string("../bin/") + WIN_LINUX("win64", "linuxsteamrt64") + "/" + library + WIN_LINUX(".dll", ".so")));
}