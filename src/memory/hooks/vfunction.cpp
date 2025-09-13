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

#include "vfunction.h"

#include <api/interfaces/manager.h>

int VFunctionHook::SetCallback(dyno::CallbackType callbackType, dyno::CallbackHandler callback)
{
    if (callbackType < dyno::CallbackType::Pre || callbackType > dyno::CallbackType::Post)
        return -1;

    if (m_bEnabled) m_pHook->addCallback(callbackType, callback);

    m_vCallbacks[static_cast<int>(callbackType)].push_back(callback);
    return m_vCallbacks[static_cast<int>(callbackType)].size() - 1;
}

void VFunctionHook::RemoveCallback(dyno::CallbackType callbackType, int cb_idx)
{
    if (callbackType < dyno::CallbackType::Pre || callbackType > dyno::CallbackType::Post)
        return;

    int cbtype = static_cast<int>(callbackType);
    if (cb_idx < 0 || cb_idx >= m_vCallbacks[cbtype].size())
        return;

    auto& cb = m_vCallbacks[cbtype][cb_idx];
    if (m_bEnabled) m_pHook->removeCallback(callbackType, cb);
    m_vCallbacks[cbtype].erase(m_vCallbacks[cbtype].begin() + cb_idx);
}

void VFunctionHook::RemoveCallback(dyno::CallbackType callbackType)
{
    if (callbackType < dyno::CallbackType::Pre || callbackType > dyno::CallbackType::Post)
        return;

    if (m_bEnabled) {
        for (auto& callback : m_vCallbacks[static_cast<int>(callbackType)]) {
            m_pHook->removeCallback(callbackType, callback);
        }
    }

    m_vCallbacks[static_cast<int>(callbackType)].clear();
}

void VFunctionHook::SetHookFunction(const std::string& interface, int index, const std::string& args, const char return_value)
{
    auto iface = g_ifaceService.GetPureInterface(interface);
    if (!iface) return;

    dyno::IHookManager& manager = dyno::IHookManager::Get();
    m_pHook = manager.hookVirtual(iface, index, [args, return_value] { return new DEFAULT_CALLCONV(GetDataObjectList(args), GetDataObject(return_value)); }).get();
}

void VFunctionHook::SetHookFunction(void* instance, int index, const std::string& args, const char return_value, bool is_vtable)
{
    if (!instance) return;

    dyno::IHookManager& manager = dyno::IHookManager::Get();
    if (is_vtable) {
        void* func = ((void**)instance)[index];
        m_pHook = manager.hookDetour(func, [args, return_value] { return new DEFAULT_CALLCONV(GetDataObjectList(args), GetDataObject(return_value)); }).get();
    }
    else {
        m_pHook = manager.hookVirtual(instance, index, [args, return_value] { return new DEFAULT_CALLCONV(GetDataObjectList(args), GetDataObject(return_value)); }).get();
    }
}

void VFunctionHook::Enable()
{
    if (!m_pHook)
        return;

    for (auto& callback : m_vCallbacks[0])
        m_pHook->addCallback(dyno::CallbackType::Pre, callback);

    for (auto& callback : m_vCallbacks[1])
        m_pHook->addCallback(dyno::CallbackType::Post, callback);

    m_bEnabled = true;
}

void VFunctionHook::Disable()
{
    if (!m_pHook)
        return;

    for (auto& callback : m_vCallbacks[0])
        m_pHook->removeCallback(dyno::CallbackType::Pre, callback);

    for (auto& callback : m_vCallbacks[1])
        m_pHook->removeCallback(dyno::CallbackType::Post, callback);

    m_bEnabled = true;
}

void* VFunctionHook::GetOriginal()
{
    if (!m_pHook)
        return nullptr;

    return (void*)m_pHook->getTarget();
}

bool VFunctionHook::IsEnabled()
{
    if (!m_pHook) return false;
    return m_pHook->isHooked();
}