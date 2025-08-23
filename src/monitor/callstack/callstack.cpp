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

#include "callstack.h"

#include <format>

uint64_t CallStack::RegisterPluginCallstack(std::string plugin_name, std::string stackMsg)
{
    std::lock_guard<std::mutex> lock(m_mutex);
    uint64_t callstack_id = m_uCallStackID++;
    m_mPluginsCallStacks[plugin_name][callstack_id] = stackMsg;
    return callstack_id;
}

void CallStack::UnregisterPluginCallstack(std::string plugin_name, uint64_t callstack_id)
{
    std::lock_guard<std::mutex> lock(m_mutex);
    if (m_mPluginsCallStacks.find(plugin_name) != m_mPluginsCallStacks.end())
    {
        m_mPluginsCallStacks[plugin_name].erase(callstack_id);
        if (m_mPluginsCallStacks[plugin_name].empty())
        {
            m_mPluginsCallStacks.erase(plugin_name);
        }
    }
}

uint64_t CallStack::RegisterExtensionCallstack(std::string extension_name, std::string stackMsg)
{
    std::lock_guard<std::mutex> lock(m_mutex);
    uint64_t callstack_id = m_uCallStackID++;
    m_mExtensionsCallStacks[extension_name][callstack_id] = stackMsg;
    return callstack_id;
}

void CallStack::UnregisterExtensionCallstack(std::string extension_name, uint64_t callstack_id)
{
    std::lock_guard<std::mutex> lock(m_mutex);
    if (m_mExtensionsCallStacks.find(extension_name) != m_mExtensionsCallStacks.end())
    {
        m_mExtensionsCallStacks[extension_name].erase(callstack_id);
        if (m_mExtensionsCallStacks[extension_name].empty())
        {
            m_mExtensionsCallStacks.erase(extension_name);
        }
    }
}

std::string CallStack::GetPluginsCallStack(std::string plugin_name)
{
    std::lock_guard<std::mutex> lock(m_mutex);
    std::string result;
    if (m_mPluginsCallStacks.find(plugin_name) != m_mPluginsCallStacks.end())
    {
        for (const auto& [id, stack] : m_mPluginsCallStacks[plugin_name])
        {
            result += std::format("[{}] {}\n", id, stack);
        }
    }
    return result;
}

std::string CallStack::GetAllPluginsCallStacks()
{
    std::lock_guard<std::mutex> lock(m_mutex);
    std::string result;
    for (const auto& [plugin_name, stacks] : m_mPluginsCallStacks)
    {
        result += std::format("Plugin: {}\n", plugin_name);
        for (const auto& [id, stack] : stacks)
        {
            result += std::format("  [{}] {}\n", id, stack);
        }
    }
    return result;
}

std::string CallStack::GetExtensionsCallStack(std::string extension_name)
{
    std::lock_guard<std::mutex> lock(m_mutex);
    std::string result;
    if (m_mExtensionsCallStacks.find(extension_name) != m_mExtensionsCallStacks.end())
    {
        for (const auto& [id, stack] : m_mExtensionsCallStacks[extension_name])
        {
            result += std::format("[{}] {}\n", id, stack);
        }
    }
    return result;
}

std::string CallStack::GetAllExtensionsCallStacks()
{
    std::lock_guard<std::mutex> lock(m_mutex);
    std::string result;
    for (const auto& [extension_name, stacks] : m_mExtensionsCallStacks)
    {
        result += std::format("Extension: {}\n", extension_name);
        for (const auto& [id, stack] : stacks)
        {
            result += std::format("  [{}] {}\n", id, stack);
        }
    }
    return result;
}

std::string CallStack::GetFullCallStack()
{
    std::lock_guard<std::mutex> lock(m_mutex);
    std::string result = "Plugins Call Stacks:\n";
    result += GetAllPluginsCallStacks();
    result += "\nExtensions Call Stacks:\n";
    result += GetAllExtensionsCallStacks();
    return result;
}