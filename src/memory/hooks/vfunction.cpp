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

void VFunctionHook::SetHookFunction(const std::string& interface, int index, void* callback)
{
    auto iface = g_ifaceService.FetchInterface<void>(interface.c_str());
    if (!iface) return;

    m_oHook = safetyhook::create_inline(((void***)iface)[0][index], callback, safetyhook::InlineHook::Flags::StartDisabled);
}

void VFunctionHook::SetHookFunction(void* instance, int index, void* callback, bool is_vtable)
{
    if (!instance) return;

    if (is_vtable) m_oHook = safetyhook::create_inline(((void**)instance)[index], callback, safetyhook::InlineHook::Flags::StartDisabled);
    else m_oHook = safetyhook::create_inline(((void***)instance)[0][index], callback, safetyhook::InlineHook::Flags::StartDisabled);
}

void VFunctionHook::Enable()
{
    if (IsEnabled()) return;

    m_oHook.enable();
}

void VFunctionHook::Disable()
{
    if (!IsEnabled()) return;

    m_oHook.disable();
}

void* VFunctionHook::GetOriginal()
{
    return (void*)(m_oHook.trampoline().address());
}

bool VFunctionHook::IsEnabled()
{
    return m_oHook.enabled();
}