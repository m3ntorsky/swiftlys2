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

#include "extension.h"

#include <api/dll/functions.h>
#include <api/shared/files.h>
#include <api/shared/plat.h>
#include <api/shared/string.h>

std::string& Extension::GetName()
{
    return m_sName;
}

bool Extension::IsLoaded()
{
    return m_bLoaded;
}

void* Extension::GetExportedFunction(std::string& name)
{
    if (!m_bLoaded) return nullptr;

    return GetBinaryFunction(m_sPath, name);
}

std::string& Extension::GetError()
{
    return m_sError;
}

bool& Extension::HasError()
{
    return m_bHasError;
}

bool Extension::Load()
{
    if (m_bLoaded)
        return true;

    m_sPath = std::string("addons/swiftly/extensions/") + WIN_LINUX("win64", "linuxsteamrt64") + WIN_LINUX("\\", "/") + m_sName + WIN_LINUX(".dll", ".so");
    if (!Files::ExistsPath(m_sPath))
    {
        m_sError = "The extension file does not exist!";
        m_bHasError = true;
        return false;
    }

    m_sError = "";
    void* m_pfExtensionClass = GetBinaryFunction(m_sPath, "GetExtensionClass", m_sError);
    if (!m_pfExtensionClass)
    {
        m_bHasError = true;
        return false;
    }

    IExtensionPlugin* (*get_extension_ptr)() = reinterpret_cast<IExtensionPlugin * (*)()>(m_pfExtensionClass);

    m_pAPI = get_extension_ptr();
    if (!m_pAPI)
    {
        m_sError = "Failed to create the extension plugin instance!";
        m_bHasError = true;
        return false;
    }

    if (!m_pAPI->Load(m_sError))
    {
        m_bHasError = true;
        m_pAPI = nullptr;
        return false;
    }

    m_bLoaded = true;
    return true;
}

bool Extension::Unload()
{
    if (!m_bLoaded)
        return true;

    if (m_pAPI)
    {
        m_sError = "";
        m_pAPI->Unload(m_sError);
        if (m_sError != "") m_bHasError = true;
    }

    ClearBinaryCache(m_sPath);

    m_bLoaded = false;
    return true;
}

IExtensionPlugin* Extension::GetAPI()
{
    return m_pAPI;
}