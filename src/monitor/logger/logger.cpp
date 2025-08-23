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

#include "logger.h"

#include <api/shared/string.h>
#include <tier0/dbg.h>

#include <format>
#include <api/shared/files.h>

#define PREFIX "[Swiftly]"

std::string GetLogTypeString(LogType type)
{
    switch (type)
    {
    case LogType::INFO:
        return "INFO";
    case LogType::WARNING:
        return "WARNING";
    case LogType::ERR:
        return "ERROR";
    case LogType::DEBUG:
        return "DEBUG";
    default:
        return "UNKNOWN";
    }
}

void Logger::Log(LogType type, const std::string& message)
{
    std::string final_output = std::format("{} [{}{}{}] {}", PREFIX, GetTerminalStringColor(GetLogTypeString(type)), GetLogTypeString(type), "{DEFAULT}", message);
    std::string color_processed = TerminalProcessColor(final_output);
    std::string without_colors = ClearTerminalColors(final_output);

    if (m_bShouldOutputToConsole[(int)type]) Msg(color_processed.c_str());

    if (m_bShouldOutputToFile[(int)type] && !m_sLogFilePaths[(int)type].empty())
    {
        Files::Append(m_sLogFilePaths[(int)type], without_colors);
    }
}

void Logger::Log(LogType type, const std::string& category, const std::string& message)
{
    if (m_bShouldOutputToConsole[(int)type] && m_sColoredCategories.contains(category))
        Log(type, std::format("[{}{}{}] {}", GetTerminalStringColor(category), category, "{DEFAULT}", message));
    else
        Log(type, std::format("[{}] {}", category, message));
}

void Logger::Info(const std::string& message)
{
    Log(LogType::INFO, message);
}

void Logger::Warning(const std::string& message)
{
    Log(LogType::WARNING, message);
}

void Logger::Error(const std::string& message)
{
    Log(LogType::ERR, message);
}

void Logger::Debug(const std::string& message)
{
    Log(LogType::DEBUG, message);
}

void Logger::Info(const std::string& category, const std::string& message)
{
    Log(LogType::INFO, category, message);
}

void Logger::Warning(const std::string& category, const std::string& message)
{
    Log(LogType::WARNING, category, message);
}

void Logger::Error(const std::string& category, const std::string& message)
{
    Log(LogType::ERR, category, message);
}

void Logger::Debug(const std::string& category, const std::string& message)
{
    Log(LogType::DEBUG, category, message);
}

void Logger::SetLogFile(LogType type, const std::string& path)
{
    m_sLogFilePaths[static_cast<int>(type)] = path;
}

void Logger::ShouldOutputToFile(LogType type, bool enabled)
{
    m_bShouldOutputToFile[static_cast<int>(type)] = enabled;
}

void Logger::ShouldColorCategoryInConsole(const std::string& category, bool enabled)
{
    if (enabled)
        m_sColoredCategories.insert(category);
    else
        m_sColoredCategories.erase(category);
}

void Logger::ShouldOutputToConsole(LogType type, bool enabled)
{
    m_bShouldOutputToConsole[static_cast<int>(type)] = enabled;
}
