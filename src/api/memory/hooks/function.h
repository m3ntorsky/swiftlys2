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

#ifndef src_api_memory_hooks_function_h
#define src_api_memory_hooks_function_h

#include <cstdint>

#include "dynohook/core.h"
#include "dynohook/os.h"
#include "dynohook/ihook.h"
#include "dynohook/imanager.h"

#if DYNO_PLATFORM_WINDOWS
#include "dynohook/conventions/x64_windows_call.h"
#define DEFAULT_CALLCONV dyno::x64WindowsCall
#else
#include "dynohook/conventions/x64_systemV_call.h"
#define DEFAULT_CALLCONV dyno::x64SystemVcall
#endif

 /*
     Args List Convention
         - p -> Pointer / any
         - b -> Boolean
         - f -> Float
         - d -> Double
         - i -> Integer 32-bit
         - u -> Unsigned Integer 32-bit
         - s -> const char*
         - I -> Integer 64-bit
         - U -> Unsigned Integer 64-bit
         - v -> Void
 */

class IFunctionHook
{
public:
    virtual void SetCallback(dyno::CallbackType callbackType, dyno::CallbackHandler callback) = 0;
    virtual void RemoveCallback(dyno::CallbackType callbackType) = 0;

    virtual void SetHookFunction(const std::string& functionSignature, const std::string& args, const char return_value) = 0;
    virtual void SetHookFunction(void* functionAddress, const std::string& args, const char return_value) = 0;

    virtual void Enable() = 0;
    virtual void Disable() = 0;

    virtual void* GetOriginal() = 0;
    virtual bool IsEnabled() = 0;
};

#endif