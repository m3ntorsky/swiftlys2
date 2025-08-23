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

#ifndef src_core_extensions_manager_h
#define src_core_extensions_manager_h

#include <api/extensions/manager.h>
#include <map>

class ExtensionManager : public IExtensionManager
{
public:
    virtual void Load() override;
    virtual void Unload() override;

    virtual bool Exists(std::string& extension_name) override;

    virtual void LoadExtension(std::string& extension_name) override;
    virtual void UnloadExtension(std::string& extension_name) override;

    virtual IExtension* GetExtension(std::string& extension_name) override;

    virtual std::vector<IExtension*>& GetExtensionsList() override;
private:
    std::vector<IExtension*> m_vExtensions;
    std::map<std::string, IExtension*> m_mExtensionsMap;
};

#endif