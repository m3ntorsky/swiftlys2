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

#include "function.h"

#include <api/interfaces/manager.h>

int FunctionHook::SetCallback(dyno::CallbackType callbackType, dyno::CallbackHandler callback)
{
    if (callbackType < dyno::CallbackType::Pre || callbackType > dyno::CallbackType::Post)
        return -1;

    m_vCallbacks[static_cast<int>(callbackType)].push_back(callback);
    return m_vCallbacks[static_cast<int>(callbackType)].size() - 1;
}

void FunctionHook::RemoveCallback(dyno::CallbackType callbackType, int cb_idx)
{
    if (callbackType < dyno::CallbackType::Pre || callbackType > dyno::CallbackType::Post)
        return;

    int cbtype = static_cast<int>(callbackType);
    if (cb_idx < 0 || cb_idx >= m_vCallbacks[cbtype].size())
        return;

    m_vCallbacks[cbtype].erase(m_vCallbacks[cbtype].begin() + cb_idx);
}

void FunctionHook::RemoveCallback(dyno::CallbackType callbackType)
{
    if (callbackType < dyno::CallbackType::Pre || callbackType > dyno::CallbackType::Post)
        return;

    m_vCallbacks[static_cast<int>(callbackType)].clear();
}

void FunctionHook::Enable()
{
    if (!m_pHook)
        return;

    for (auto& callback : m_vCallbacks[0])
        m_pHook->addCallback(dyno::CallbackType::Pre, callback);

    for (auto& callback : m_vCallbacks[1])
        m_pHook->addCallback(dyno::CallbackType::Post, callback);
}

void FunctionHook::Disable()
{
    if (!m_pHook)
        return;

    for (auto& callback : m_vCallbacks[0])
        m_pHook->removeCallback(dyno::CallbackType::Pre, callback);

    for (auto& callback : m_vCallbacks[1])
        m_pHook->removeCallback(dyno::CallbackType::Post, callback);
}

void* FunctionHook::GetOriginal()
{
    if (!m_pHook)
        return nullptr;

    return (void*)m_pHook->getTarget();
}

bool FunctionHook::IsEnabled()
{
    if (!m_pHook) return false;
    return m_pHook->isHooked();
}

void FunctionHook::SetHookFunction(const std::string& functionSignature, const std::string& args, const char return_value)
{
    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);
    void* functionAddress = gamedata->GetSignatures()->Fetch(functionSignature);

    if (!functionAddress) return;

    dyno::IHookManager& manager = dyno::IHookManager::Get();
    m_pHook = manager.hookDetour(functionAddress, [args, return_value] { return new DEFAULT_CALLCONV(GetDataObjectList(args), GetDataObject(return_value)); }).get();
}

void FunctionHook::SetHookFunction(void* functionAddress, const std::string& args, const char return_value)
{
    if (!functionAddress) return;

    dyno::IHookManager& manager = dyno::IHookManager::Get();
    m_pHook = manager.hookDetour(functionAddress, [args, return_value] { return new DEFAULT_CALLCONV(GetDataObjectList(args), GetDataObject(return_value)); }).get();
}