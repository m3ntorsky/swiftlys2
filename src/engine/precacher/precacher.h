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

#ifndef src_engine_precacher_precacher_h
#define src_engine_precacher_precacher_h

#include <api/engine/precacher/precacher.h>

#include <set>
#include <api/utils/mutex.h>

class CPrecacher : public IPrecacher
{
public:
    virtual void AddItem(const std::string& item) override;
    virtual bool HasItemInList(const std::string& item) override;
    virtual void CacheItems(IEntityResourceManifest* pResourceManifest) override;
    virtual bool IsItemCached(const std::string& item) override;
    virtual void RemoveItem(const std::string& item) override;

private:
    std::set<std::string> m_sCacheItems;
    std::set<std::string> m_sCachedItems;

    QueueMutex m_mtxLock;
};

#endif