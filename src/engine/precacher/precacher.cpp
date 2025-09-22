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

#include "precacher.h"

#include <api/interfaces/manager.h>
#include <api/memory/virtual/call.h>

void CPrecacher::AddItem(const std::string& item)
{
    QueueLockGuard lock(m_mtxLock);
    if (m_sCacheItems.contains(item)) return;
    if (m_sCachedItems.contains(item)) return;
    if (item.size() <= 0) return;

    m_sCacheItems.insert(item);
}

bool CPrecacher::HasItemInList(const std::string& item)
{
    return m_sCacheItems.contains(item);
}

void CPrecacher::CacheItems(IEntityResourceManifest* pResourceManifest)
{
    QueueLockGuard lock(m_mtxLock);
    static auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);
    static auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    static int l_iAddResourceOffset = gamedata->GetOffsets()->Fetch("CEntityResourceManifest::AddResource");

    for (const auto& item : m_sCacheItems)
    {
        CALL_VIRTUAL(void, l_iAddResourceOffset, pResourceManifest, item.c_str());
        m_sCachedItems.insert(item);
        logger->Info("Precacher", std::format("Precached item: '{}'.\n", item));
    }
}

bool CPrecacher::IsItemCached(const std::string& item)
{
    return m_sCachedItems.contains(item);
}

void CPrecacher::RemoveItem(const std::string& item)
{
    QueueLockGuard lock(m_mtxLock);
    if (!m_sCacheItems.contains(item)) return;
    m_sCacheItems.erase(item);
}