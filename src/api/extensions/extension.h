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

#ifndef src_api_extensions_extension_h
#define src_api_extensions_extension_h

#include <string>

#include "plugin.h"

class IExtension
{
public:
    virtual std::string& GetName() = 0;
    virtual bool IsLoaded() = 0;

    virtual void* GetExportedFunction(std::string& name) = 0;

    virtual std::string& GetError() = 0;
    virtual bool& HasError() = 0;

    virtual bool Load(bool late) = 0;
    virtual bool Unload() = 0;

    virtual IExtensionPlugin* GetAPI() = 0;
};

#endif