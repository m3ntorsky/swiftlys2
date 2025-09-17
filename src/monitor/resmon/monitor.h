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

#ifndef src_monitor_resmon_monitor_h
#define src_monitor_resmon_monitor_h

#include <api/monitor/resmon/monitor.h>

#include <api/utils/mutex.h>

struct RecordInfo
{
    char event;
    int64_t timestamp;
    std::string name;
    std::string plugin_name;
};

class ResourceMonitor : public IResourceMonitor
{
public:
    virtual bool Enable() override;
    virtual bool Disable() override;
    virtual bool IsEnabled() override;

    virtual void RecordTime(std::string plugin_name, std::string key, double time) override;

    virtual void StartRecording(std::string plugin_name, std::string key) override;
    virtual void StopRecording(std::string plugin_name, std::string key) override;

    virtual std::map<std::string, std::map<std::string, std::vector<double>>> GetPerformanceData() override;
    virtual std::string GetPerformanceAsJSON(std::string plugin_name = "") override;
private:
    bool m_bEnabled = false;
    std::map<std::string, std::map<std::string, std::vector<double>>> m_mPerformanceData;
    std::map<std::string, std::map<std::string, double>> m_mOngoingRecords;

    std::vector<RecordInfo> m_vProfilerEvents;

    QueueMutex m_mtxLock;

    void ClearData();
};

#endif