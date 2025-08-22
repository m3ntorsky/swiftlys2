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

#ifndef src_api_extensions_plugin_h
#define src_api_extensions_plugin_h

#include <string>

class IExtensionPlugin
{
public:
    virtual bool Load(std::string& error) = 0;
    virtual bool Unload(std::string& error) = 0;
    virtual void AllExtensionsLoaded() = 0;
    virtual void AllPluginsLoaded() = 0;

    virtual bool OnPluginLoad(std::string pluginName, std::string& error) = 0;
    virtual bool OnPluginUnload(std::string pluginName, std::string& error) = 0;

    virtual const char* GetAuthor() = 0;
    virtual const char* GetName() = 0;
    virtual const char* GetVersion() = 0;
    virtual const char* GetWebsite() = 0;
};

#endif