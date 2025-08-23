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

#ifndef src_monitor_callstack_callstack_h
#define src_monitor_callstack_callstack_h

#include <api/monitor/callstack/callstack.h>
#include <mutex>

class CallStack : public ICallStack
{
public:
    virtual uint64_t RegisterPluginCallstack(std::string plugin_name, std::string stackMsg) override;
    virtual void UnregisterPluginCallstack(std::string plugin_name, uint64_t callstack_id) override;

    virtual uint64_t RegisterExtensionCallstack(std::string extension_name, std::string stackMsg) override;
    virtual void UnregisterExtensionCallstack(std::string extension_name, uint64_t callstack_id) override;

    virtual std::string GetPluginsCallStack(std::string plugin_name) override;
    virtual std::string GetAllPluginsCallStacks() override;

    virtual std::string GetExtensionsCallStack(std::string extension_name) override;
    virtual std::string GetAllExtensionsCallStacks() override;

    virtual std::string GetFullCallStack() override;
private:
    std::unordered_map<std::string, std::unordered_map<uint64_t, std::string>> m_mPluginsCallStacks;
    std::unordered_map<std::string, std::unordered_map<uint64_t, std::string>> m_mExtensionsCallStacks;
    uint64_t m_uCallStackID = 0;

    std::mutex m_mutex;
};

#endif