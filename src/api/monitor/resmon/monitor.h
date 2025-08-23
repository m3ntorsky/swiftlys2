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

#ifndef src_api_monitor_resmon_monitor_h
#define src_api_monitor_resmon_monitor_h

#include <string>
#include <map>
#include <vector>

class IResourceMonitor
{
public:
    virtual bool Enable() = 0;
    virtual bool Disable() = 0;
    virtual bool IsEnabled() = 0;

    virtual void RecordTime(std::string plugin_name, std::string key, double time) = 0;

    virtual void StartRecording(std::string plugin_name, std::string key) = 0;
    virtual void StopRecording(std::string plugin_name, std::string key) = 0;

    virtual std::map<std::string, std::map<std::string, std::vector<double>>> GetPerformanceData() = 0;
    virtual std::string GetPerformanceAsJSON(std::string plugin_name = "") = 0;
};

#endif