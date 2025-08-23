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

#ifndef src_core_extensions_extension_h
#define src_core_extensions_extension_h

#include <api/extensions/extension.h>

class Extension : public IExtension
{
public:
    Extension(std::string name) : m_sName(name) {};
    ~Extension() = default;

    virtual std::string& GetName() override;
    virtual bool IsLoaded() override;

    virtual void* GetExportedFunction(std::string& name) override;

    virtual std::string& GetError() override;
    virtual bool& HasError() override;

    virtual bool Load() override;
    virtual bool Unload() override;

    virtual IExtensionPlugin* GetAPI() override;
private:
    std::string m_sPath;

    std::string m_sName;
    bool m_bLoaded = false;

    IExtensionPlugin* m_pAPI = nullptr;

    std::string m_sError;
    bool m_bHasError = false;
};

#endif