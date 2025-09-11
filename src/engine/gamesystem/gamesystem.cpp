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

#include "gamesystem.h"

#include <api/interfaces/manager.h>

CBaseGameSystemFactory** CBaseGameSystemFactory::sm_pFirst = nullptr;

CGameSystem g_GameSystem;
IGameSystemFactory* CGameSystem::sm_Factory = nullptr;

bool InitGameSystem()
{
    /*
    taken straight from CS2Fixes, thanks for the code S2ZE
    <https://github.com/Source2ZE/CS2Fixes/blob/adceddd585420a6e32a70ea9bef7731963c6431d/src/gamesystem.cpp#L47-L74>
    */
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);

    void* ptr = gamedata->GetSignatures()->Fetch("IGameSystem::InitAllSystems->pFirst");
    if (!ptr) {
        logger->Error("Game System", "Couldn't find signature for 'IGameSystem::InitAllSystems->pFirst'!\n");
        return false;
    }

    uintptr_t pAddr = (uintptr_t)ptr;

    pAddr += 3;

    uint32_t offset = *(uint32_t*)pAddr;

    pAddr += 4;

    CBaseGameSystemFactory::sm_pFirst = (CBaseGameSystemFactory**)(pAddr + offset);

    CGameSystem::sm_Factory = new CGameSystemStaticFactory<CGameSystem>("SwiftlyS2_GameSystem", &g_GameSystem);

    return true;
}

bool ShutdownGameSystem()
{
    /*
    taken straight from CS2Fixes, thanks for the code S2ZE
    <https://github.com/Source2ZE/CS2Fixes/blob/adceddd585420a6e32a70ea9bef7731963c6431d/src/gamesystem.cpp#L76-L156>
    */
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);

    void* ptr = gamedata->GetSignatures()->Fetch("IGameSystem::LoopPostInitAllSystems->pEventDispatcher");
    if (!ptr) {
        logger->Error("Game System", "Couldn't find signature for 'IGameSystem::LoopPostInitAllSystems->pEventDispatcher'!\n");
        return false;
    }

    uintptr_t pAddr = (uintptr_t)ptr;

    pAddr += 3;

    uint32_t offset = *(uint32_t*)pAddr;

    pAddr += 4;

    CGameSystemEventDispatcher** ppDispatchers = (CGameSystemEventDispatcher**)(pAddr + offset);

    ptr = gamedata->GetSignatures()->Fetch("IGameSystem::LoopDestroyAllSystems->s_GameSystems");
    if (!ptr) {
        logger->Error("Game System", "Couldn't find signature for 'IGameSystem::LoopDestroyAllSystems->s_GameSystems'!\n");
        return false;
    }

    pAddr += 2;

    offset = *(uint32*)pAddr;

    pAddr += 4;

    CUtlVector<AddedGameSystem_t>* pGameSystems = (CUtlVector<AddedGameSystem_t>*)(pAddr + offset);

    auto* pDispatcher = *ppDispatchers;

    if (!pDispatcher || !pGameSystems)
    {
        logger->Error("Game System", "Gamesystems and/or dispatchers is null, server is probably shutting down\n");
        return false;
    }

    auto& funcListeners = *pDispatcher->m_funcListeners;
    auto& gameSystems = *pGameSystems;

    FOR_EACH_VEC_BACK(gameSystems, i)
    {
        if (&g_GameSystem == gameSystems[i].m_pGameSystem)
        {
            gameSystems.FastRemove(i);
            break;
        }
    }

    FOR_EACH_VEC_BACK(funcListeners, i)
    {
        auto& vecListeners = funcListeners[i];

        FOR_EACH_VEC_BACK(vecListeners, j)
        {
            if (&g_GameSystem == vecListeners[j])
            {
                vecListeners.FastRemove(j);

                break;
            }
        }

        if (!vecListeners.Count())
            funcListeners.FastRemove(i);
    }

    CGameSystem::sm_Factory->DestroyGameSystem(&g_GameSystem);

    return true;
}

GS_EVENT_MEMBER(CGameSystem, BuildGameSessionManifest)
{
    IEntityResourceManifest* pResourceManifest = msg->m_pResourceManifest;
}