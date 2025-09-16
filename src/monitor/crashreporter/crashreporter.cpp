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

#include "crashreporter.h"

#include <api/interfaces/manager.h>
#include <api/shared/texttable.h>
#include <api/shared/string.h>
#include <api/shared/files.h>

#include <public/eiface.h>

#include <format>

void CrashReporter::Init()
{
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
    if (!Files::ExistsPath("addons/swiftly/dumps"))
    {
        if (!Files::CreateDir("addons/swiftly/dumps"))
        {
            logger->Error("Crash Listener", "Couldn't create dumps folder.\n");
            return;
        }
    }

    if (!Files::ExistsPath("addons/swiftly/dumps/prevention"))
    {
        if (!Files::CreateDir("addons/swiftly/dumps/prevention"))
        {
            logger->Error("Crash Listener", "Couldn't create dumps prevention folder.\n");
            return;
        }
    }
}

void CrashReporter::Shutdown()
{
}


void CrashReporter::ReportPreventionIncident(std::string category, std::string reason)
{
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);

    logger->Warning("Crash Prevention", "A crash has been prevented by Swiftly Core and the details will be listed below:\n");

    TextTable backtraceTable('-', '|', '+');

    backtraceTable.add(" Category ");
    backtraceTable.add(" Message ");
    backtraceTable.endOfRow();

    backtraceTable.add(std::format(" {} ", category));
    backtraceTable.add(std::format(" {} ", reason));
    backtraceTable.endOfRow();

    PrintTextTable(LogType::WARNING, "Crash Prevention", backtraceTable);

    std::string file_path = std::format("addons/swiftly/dumps/prevention/incident.%s.log", get_uuid());
    if (Files::ExistsPath(file_path)) Files::Delete(file_path);

    Files::Append(file_path, std::format("================================\nCategory: {}\nDetails: {}", category, reason), false);
    logger->Warning("Crash Prevention", std::format("A log file has been created at: {}\n", file_path));
}