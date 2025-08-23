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

#include "allocator.h"

void* MemoryAllocator::Alloc(uint64_t size)
{
    void* ptr = malloc(size);
    if (ptr)
    {
        allocations[ptr] = size;
        totalAllocated += size;
    }
    return ptr;
}

void* MemoryAllocator::TrackedAlloc(uint64_t size, std::string identifier, std::string details)
{
    void* ptr = Alloc(size);
    if (ptr)
    {
        trackedAllocations[identifier].push_back({ details, ptr });
    }
    return ptr;
}

void MemoryAllocator::Free(void* ptr)
{
    auto it = allocations.find(ptr);
    if (it != allocations.end())
    {
        totalAllocated -= it->second;
        allocations.erase(it);

        for (auto& [id, vec] : trackedAllocations)
        {
            vec.erase(std::remove_if(vec.begin(), vec.end(),
                [ptr](const std::pair<std::string, void*>& p) { return p.second == ptr; }),
                vec.end());
        }

        free(ptr);
    }
}

void* MemoryAllocator::Resize(void* ptr, uint64_t newSize)
{
    auto it = allocations.find(ptr);
    if (it != allocations.end())
    {
        uint64_t oldSize = it->second;
        void* newPtr = realloc(ptr, newSize);
        if (newPtr)
        {
            allocations.erase(it);
            allocations[newPtr] = newSize;
            totalAllocated = totalAllocated - oldSize + newSize;

            for (auto& [id, vec] : trackedAllocations)
            {
                for (auto& [details, p] : vec)
                {
                    if (p == ptr)
                    {
                        p = newPtr;
                        break;
                    }
                }
            }

            return newPtr;
        }
    }
    return nullptr;
}

uint64_t MemoryAllocator::GetSize(void* ptr)
{
    auto it = allocations.find(ptr);
    if (it != allocations.end())
    {
        return it->second;
    }
    return 0;
}

uint64_t MemoryAllocator::GetTotalAllocated()
{
    return totalAllocated;
}

uint64_t MemoryAllocator::GetAllocatedByTrackedIdentifier(std::string identifier)
{
    uint64_t total = 0;
    auto it = trackedAllocations.find(identifier);
    if (it != trackedAllocations.end())
    {
        for (const auto& [details, ptr] : it->second)
        {
            total += GetSize(ptr);
        }
    }
    return total;
}

std::vector<std::pair<std::string, void*>> MemoryAllocator::GetTrackedAllocations(std::string identifier)
{
    auto it = trackedAllocations.find(identifier);
    if (it != trackedAllocations.end())
    {
        return it->second;
    }
    return {};
}

bool MemoryAllocator::IsPointerValid(void* ptr)
{
    return allocations.contains(ptr);
}

void MemoryAllocator::CopyMemory(void* dest, const void* src, uint64_t size)
{
    memcpy(dest, src, size);
}

std::map<void*, uint64_t> MemoryAllocator::GetAllocations()
{
    return allocations;
}

MemoryAllocator::~MemoryAllocator()
{
    for (const auto& [ptr, size] : allocations)
    {
        free(ptr);
    }
    allocations.clear();
    trackedAllocations.clear();
    totalAllocated = 0;
}