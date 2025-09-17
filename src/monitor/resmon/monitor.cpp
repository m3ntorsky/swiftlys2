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

#include "monitor.h"

#include <chrono>

#include <nlohmann/json.hpp>

bool ResourceMonitor::Enable()
{
    if (m_bEnabled)
        return false;

    QueueLockGuard lock(m_mtxLock);
    m_bEnabled = true;
    ClearData();
    return true;
}

bool ResourceMonitor::Disable()
{
    if (!m_bEnabled)
        return false;

    QueueLockGuard lock(m_mtxLock);
    m_bEnabled = false;
    ClearData();
    return true;
}

bool ResourceMonitor::IsEnabled()
{
    return m_bEnabled;
}

void ResourceMonitor::RecordTime(std::string plugin_name, std::string key, double time)
{
    if (!m_bEnabled)
        return;

    QueueLockGuard lock(m_mtxLock);
    m_mPerformanceData[plugin_name][key].push_back(time);
}

void ResourceMonitor::StartRecording(std::string plugin_name, std::string key)
{
    if (!m_bEnabled)
        return;

    QueueLockGuard lock(m_mtxLock);
    auto registered_timestamp = std::chrono::high_resolution_clock::now().time_since_epoch();
    m_mOngoingRecords[plugin_name][key] = std::chrono::duration<double, std::milli>(registered_timestamp).count();

    RecordInfo info;
    info.event = 'B';
    info.timestamp = std::chrono::duration_cast<std::chrono::microseconds>(registered_timestamp).count();
    info.name = key;
    info.plugin_name = plugin_name;

    m_vProfilerEvents.push_back(info);
}

void ResourceMonitor::StopRecording(std::string plugin_name, std::string key)
{
    if (!m_bEnabled)
        return;

    auto it_plugin = m_mOngoingRecords.find(plugin_name);
    if (it_plugin == m_mOngoingRecords.end())
        return;

    auto it_key = it_plugin->second.find(key);
    if (it_key == it_plugin->second.end())
        return;

    QueueLockGuard lock(m_mtxLock);
    double start_time = it_key->second;
    auto registered_timestamp = std::chrono::high_resolution_clock::now().time_since_epoch();
    double end_time = std::chrono::duration<double, std::milli>(registered_timestamp).count();
    double elapsed_time = end_time - start_time;

    RecordInfo info;
    info.event = 'E';
    info.timestamp = std::chrono::duration_cast<std::chrono::microseconds>(registered_timestamp).count();
    info.name = key;
    info.plugin_name = plugin_name;

    m_vProfilerEvents.push_back(info);

    m_mPerformanceData[plugin_name][key].push_back(elapsed_time);
    it_plugin->second.erase(it_key);

    if (it_plugin->second.empty())
        m_mOngoingRecords.erase(it_plugin);
}

std::map<std::string, std::map<std::string, std::vector<double>>> ResourceMonitor::GetPerformanceData()
{
    return m_mPerformanceData;
}

std::string ResourceMonitor::GetPerformanceAsJSON(std::string plugin_name)
{
    nlohmann::json j;
    j["traceEvents"] = nlohmann::json::array();

    auto timings = m_vProfilerEvents;
    auto iter_end = timings.end();

    std::map<std::string, std::map<std::string, std::string>> cacheItems;

    for (auto it = timings.begin(); it != iter_end; ++it)
    {
        auto& record = *it;

        if (!plugin_name.empty() && record.plugin_name != plugin_name)
            continue;

        auto event_name = cacheItems[record.plugin_name][record.name];
        if (event_name.empty())
        {
            auto calls = m_mPerformanceData[record.plugin_name][record.name];
            auto [min, max] = std::minmax_element(calls.begin(), calls.end());

            double average = 0.0;
            for (const auto& call : calls)
                average += call;

            average /= calls.size();

            event_name = record.name + " [" + record.plugin_name + "] (min=" + ((*min) < 0.5 ? std::to_string(*min * 1000.0) + "μs" : std::to_string(*min) + "ms") +
                ", max=" + ((*max) < 0.5 ? std::to_string(*max * 1000.0) + "μs" : std::to_string(*max) + "ms") +
                ", avg=" + (average < 0.5 ? std::to_string(average * 1000.0) + "μs" : std::to_string(average) + "ms") +
                ", count=" + std::to_string(calls.size()) + ")";

            cacheItems[record.plugin_name][record.name] = event_name;
        }

        nlohmann::json j_event;
        j_event["name"] = event_name;
        j_event["ph"] = std::string(1, record.event);
        j_event["ts"] = record.timestamp;
        j_event["pid"] = 0;
        j_event["tid"] = 0;
        j["traceEvents"].push_back(j_event);
    }

    return j.dump(4);
}

void ResourceMonitor::ClearData()
{
    QueueLockGuard lock(m_mtxLock);
    m_mPerformanceData.clear();
    m_mOngoingRecords.clear();
    m_vProfilerEvents.clear();
}