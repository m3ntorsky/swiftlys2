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

#ifndef src_monitor_logger_logger_h
#define src_monitor_logger_logger_h

#include <string>
#include <api/monitor/logger/logger.h>

#include <set>

class Logger : public ILogger
{
public:
    void Log(LogType type, const std::string& message) override;
    void Log(LogType type, const std::string& category, const std::string& message) override;

    void Info(const std::string& message) override;
    void Warning(const std::string& message) override;
    void Error(const std::string& message) override;
    void Debug(const std::string& message) override;

    void Info(const std::string& category, const std::string& message) override;
    void Warning(const std::string& category, const std::string& message) override;
    void Error(const std::string& category, const std::string& message) override;
    void Debug(const std::string& category, const std::string& message) override;

    void SetLogFile(LogType type, const std::string& path) override;
    void ShouldOutputToFile(LogType type, bool enabled) override;

    void ShouldColorCategoryInConsole(const std::string& category, bool enabled) override;
    void ShouldOutputToConsole(LogType type, bool enabled) override;
private:
    bool m_bShouldOutputToConsole[4] = { true, true, true, true };
    bool m_bShouldOutputToFile[4] = { false, false, false, false };
    std::string m_sLogFilePaths[4] = { "", "", "", "" };
    std::set<std::string> m_sColoredCategories;
};

#endif