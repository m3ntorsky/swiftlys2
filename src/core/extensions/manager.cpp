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

#include "manager.h"
#include "extension.h"

#include <api/shared/files.h>
#include <api/shared/plat.h>
#include <api/shared/string.h>

bool all_loaded = false;

void ExtensionManager::Load()
{
    std::string baseDir = std::string("addons/swiftly/extensions/") + WIN_LINUX("win64", "linuxsteamrt64");
    if (!Files::ExistsPath(baseDir))
        Files::CreateDir(baseDir);

    std::vector<std::string> extensions = Files::FetchFileNames(baseDir);
    for (auto& extension : extensions)
    {
        if (extension.find("disabled") != std::string::npos)
            continue;

        extension = replace(extension, baseDir, "");
        std::string extension_name = replace(replace(extension, WIN_LINUX("\\", "/"), ""), WIN_LINUX(".dll", ".so"), "");

        LoadExtension(extension_name);
    }

    all_loaded = true;
    for (auto& ext : m_vExtensions)
        if (ext->IsLoaded())
            ext->GetAPI()->AllExtensionsLoaded();
}

void ExtensionManager::Unload()
{
    std::vector<std::string> extension_names;
    for (auto& ext : m_vExtensions)
        extension_names.push_back(ext->GetName());

    for (auto& extension_name : extension_names)
        UnloadExtension(extension_name);

    all_loaded = false;
}

bool ExtensionManager::Exists(std::string& extension_name)
{
    return m_mExtensionsMap.contains(extension_name);
}

void ExtensionManager::LoadExtension(std::string& extension_name)
{
    if (Exists(extension_name))
        return;

    IExtension* extension = new Extension(extension_name);
    if (!extension->Load())
    {
        printf("Not loaded: %s\n", extension->GetError().c_str());
        delete extension;
        return;
    }

    m_vExtensions.push_back(extension);
    m_mExtensionsMap[extension_name] = extension;
    if (all_loaded)
        extension->GetAPI()->AllExtensionsLoaded();
}

void ExtensionManager::UnloadExtension(std::string& extension_name)
{
    if (!Exists(extension_name))
        return;

    IExtension* extension = m_mExtensionsMap.at(extension_name);
    if (extension->IsLoaded())
        if (!extension->Unload())
            return;

    m_mExtensionsMap.erase(extension_name);
    m_vExtensions.erase(std::remove(m_vExtensions.begin(), m_vExtensions.end(), extension), m_vExtensions.end());
    delete extension;
}

IExtension* ExtensionManager::GetExtension(std::string& extension_name)
{
    if (!m_mExtensionsMap.contains(extension_name)) return nullptr;
    return m_mExtensionsMap.at(extension_name);
}

std::vector<IExtension*>& ExtensionManager::GetExtensionsList()
{
    return m_vExtensions;
}