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

#ifndef src_memory_hooks_vfunction_h
#define src_memory_hooks_vfunction_h

#include <api/memory/hooks/vfunction.h>

#include <vector>

dyno::DataObject GetDataObject(char arg);
std::vector<dyno::DataObject> GetDataObjectList(std::string args);

class VFunctionHook : public IVFunctionHook
{
public:
    virtual int SetCallback(dyno::CallbackType callbackType, dyno::CallbackHandler callback) override;
    virtual void RemoveCallback(dyno::CallbackType callbackType, int cb_idx) override;
    virtual void RemoveCallback(dyno::CallbackType callbackType) override;

    virtual void SetHookFunction(const std::string& interface, int index, const std::string& args, const char return_value) override;
    virtual void SetHookFunction(void* instance, int index, const std::string& args, const char return_value, bool is_vtable) override;

    virtual void Enable() override;
    virtual void Disable() override;

    virtual void* GetOriginal() override;
    virtual bool IsEnabled() override;
private:
    dyno::IHook* m_pHook = nullptr;

    std::vector<dyno::CallbackHandler> m_vCallbacks[2];
};

#endif