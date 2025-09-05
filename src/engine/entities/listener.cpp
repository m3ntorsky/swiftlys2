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

#include "listener.h"
#include "entitysystem.h"

#include <api/interfaces/manager.h>
#include <api/shared/plat.h>

CEntityListener g_entityListener;

void CEntityListener::OnEntitySpawned(CEntityInstance* pEntity)
{
}

void CEntityListener::OnEntityParentChanged(CEntityInstance* pEntity, CEntityInstance* pNewParent)
{
}

void EntityAllowHammerID(CEntityInstance* pEntity)
{
    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);
    Plat_WriteMemory((*(void***)pEntity)[gamedata->GetOffsets()->Fetch("GetHammerUniqueID")], (uint8_t*)"\xB0\x01", 2);
}

bool bDone = false;

void CEntityListener::OnEntityCreated(CEntityInstance* pEntity)
{
    if (!bDone) {
        bDone = true;
        EntityAllowHammerID(pEntity);
    }

    // @todo: Schema
    // if (std::string(pEntity->GetClassname()) == "cs_gamerules")
        // g_pGameRules = schema::GetProp<void*>(pEntity, "CCSGameRulesProxy", "m_pGameRules");
}

void CEntityListener::OnEntityDeleted(CEntityInstance* pEntity)
{
}