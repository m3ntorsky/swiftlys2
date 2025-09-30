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

#include "string.h"
#include "plat.h"

#include <api/interfaces/manager.h>

#include <map>
#include <random>
#include <chrono>

#include <regex>

#include <fmt/format.h>

const char* wws = " \t\n\r\f\v";

std::map<std::string, std::string> terminalColors = {
    {"{DEFAULT}", WIN_LINUX("\033[38;2;255;255;255m", "\e[39m")},
    {"{WHITE}", WIN_LINUX("\033[38;2;255;255;255m", "\e[39m")},
    {"{DARKRED}", WIN_LINUX("\x1B[31m", "\e[31m")},
    {"{LIGHTPURPLE}", WIN_LINUX("\x1B[95m", "\e[95m")},
    {"{GREEN}", WIN_LINUX("\x1B[32m", "\e[32m")},
    {"{OLIVE}", WIN_LINUX("\x1B[33m", "\e[33m")},
    {"{LIME}", WIN_LINUX("\x1B[92m", "\e[92m")},
    {"{RED}", WIN_LINUX("\x1B[31m", "\e[31m")},
    {"{GRAY}", WIN_LINUX("\x1B[37m", "\e[37m")},
    {"{GREY}", WIN_LINUX("\x1B[37m", "\e[37m")},
    {"{LIGHTYELLOW}", WIN_LINUX("\x1B[93m", "\e[93m")},
    {"{YELLOW}", WIN_LINUX("\x1B[93m", "\e[93m")},
    {"{SILVER}", WIN_LINUX("\x1B[37m", "\e[37m")},
    {"{BLUEGREY}", WIN_LINUX("\x1B[94m", "\e[94m")},
    {"{LIGHTBLUE}", WIN_LINUX("\x1B[94m", "\e[94m")},
    {"{BLUE}", WIN_LINUX("\x1B[34m", "\e[34m")},
    {"{DARKBLUE}", WIN_LINUX("\x1B[34m", "\e[34m")},
    {"{PURPLE}", WIN_LINUX("\x1B[35m", "\e[35m")},
    {"{MAGENTA}", WIN_LINUX("\x1B[35m", "\e[35m")},
    {"{LIGHTRED}", WIN_LINUX("\x1B[91m", "\e[91m")},
    {"{GOLD}", WIN_LINUX("\x1B[93m", "\e[93m")},
    {"{ORANGE}", WIN_LINUX("\x1B[33m", "\e[33m")},

    {"{BGDEFAULT}", WIN_LINUX("\x1B[40m", "\e[40m")},
    {"{BGDARKRED}", WIN_LINUX("\x1B[41m", "\e[41m")},
    {"{BGLIGHTPURPLE}", WIN_LINUX("\x1B[105m", "\e[105m")},
    {"{BGGREEN}", WIN_LINUX("\x1B[42m", "\e[42m")},
    {"{BGOLIVE}", WIN_LINUX("\x1B[43m", "\e[43m")},
    {"{BGLIME}", WIN_LINUX("\x1B[102m", "\e[102m")},
    {"{BGRED}", WIN_LINUX("\x1B[41m", "\e[41m")},
    {"{BGGRAY}", WIN_LINUX("\x1B[47m", "\e[47m")},
    {"{BGGREY}", WIN_LINUX("\x1B[47m", "\e[47m")},
    {"{BGLIGHTYELLOW}", WIN_LINUX("\x1B[103m", "\e[103m")},
    {"{BGYELLOW}", WIN_LINUX("\x1B[103m", "\e[103m")},
    {"{BGSILVER}", WIN_LINUX("\x1B[47m", "\e[47m")},
    {"{BGBLUEGREY}", WIN_LINUX("\x1B[104m", "\e[104m")},
    {"{BGLIGHTBLUE}", WIN_LINUX("\x1B[104m", "\e[104m")},
    {"{BGBLUE}", WIN_LINUX("\x1B[44m", "\e[44m")},
    {"{BGDARKBLUE}", WIN_LINUX("\x1B[44m", "\e[44m")},
    {"{BGPURPLE}", WIN_LINUX("\x1B[45m", "\e[45m")},
    {"{BGMAGENTA}", WIN_LINUX("\x1B[45m", "\e[45m")},
    {"{BGLIGHTRED}", WIN_LINUX("\x1B[101m", "\e[101m")},
    {"{BGGOLD}", WIN_LINUX("\x1B[103m", "\e[103m")},
    {"{BGORANGE}", WIN_LINUX("\x1B[43m", "\e[43m")},
};

std::vector<std::string> terminalPrefixColors = {
    "{DEFAULT}",
    "{WHITE}",
    "{DARKRED}",
    "{LIGHTPURPLE}",
    "{GREEN}",
    "{OLIVE}",
    "{LIME}",
    "{RED}",
    "{LIGHTYELLOW}",
    "{YELLOW}",
    "{BLUEGREY}",
    "{LIGHTBLUE}",
    "{BLUE}",
    "{DARKBLUE}",
    "{PURPLE}",
    "{MAGENTA}",
    "{LIGHTRED}",
    "{GOLD}",
    "{ORANGE}",
};

std::map<std::string, std::string> colors = {
    {"{DEFAULT}", "\x01"},
    {"{WHITE}", "\x01"},
    {"{DARKRED}", "\x02"},
    {"{LIGHTPURPLE}", "\x03"},
    {"{GREEN}", "\x04"},
    {"{OLIVE}", "\x05"},
    {"{LIME}", "\x06"},
    {"{RED}", "\x07"},
    {"{GRAY}", "\x08"},
    {"{GREY}", "\x08"},
    {"{LIGHTYELLOW}", "\x09"},
    {"{YELLOW}", "\x09"},
    {"{SILVER}", "\x0A"},
    {"{BLUEGREY}", "\x0A"},
    {"{LIGHTBLUE}", "\x0B"},
    {"{BLUE}", "\x0B"},
    {"{DARKBLUE}", "\x0C"},
    {"{PURPLE}", "\x0E"},
    {"{MAGENTA}", "\x0E"},
    {"{LIGHTRED}", "\x0F"},
    {"{GOLD}", "\x10"},
    {"{ORANGE}", "\x10"},
};

std::string ProcessColor(std::string str, int team)
{
    str = replace(str, "{TEAMCOLOR}", team == 3 ? "{LIGHTBLUE}" : (team == 2 ? "{YELLOW}" : "{LIGHTPURPLE}"));
    str = replace(str, "{teamcolor}", team == 3 ? "{lightblue}" : (team == 2 ? "{yellow}" : "{lightpurple}"));
    for (auto it = colors.begin(); it != colors.end(); ++it)
    {
        str = replace(str, it->first, it->second);
        str = replace(str, str_tolower(it->first), it->second);
    }
    return str;
}

std::string ClearColors(std::string str)
{
    str = replace(str, "{TEAMCOLOR}", "");
    str = replace(str, "{teamcolor}", "");
    for (auto it = terminalColors.begin(); it != terminalColors.end(); ++it)
    {
        str = replace(str, it->first, "");
        str = replace(str, str_tolower(it->first), "");
    }
    return str;
}

std::string TerminalProcessColor(std::string str)
{
    for (auto it = terminalColors.begin(); it != terminalColors.end(); ++it)
    {
        str = replace(str, it->first, it->second);
        str = replace(str, str_tolower(it->first), it->second);
    }
    return str;
}

std::string ClearTerminalColors(std::string str)
{
    for (auto it = terminalColors.begin(); it != terminalColors.end(); ++it)
    {
        str = replace(str, it->first, "");
        str = replace(str, str_tolower(it->first), "");
    }
    return str;
}

std::string GetTerminalStringColor(std::string plugin_name)
{
    auto hash = hash_64_fnv1a_const(plugin_name.c_str());
    uint64_t steps = (hash % terminalPrefixColors.size());
    return terminalPrefixColors[steps];
}

std::string replace(std::string str, const std::string from, const std::string to)
{
    if (from.empty())
        return str;
    int start_pos = 0;
    while ((start_pos = str.find(from, start_pos)) != std::string::npos)
    {
        str.replace(start_pos, from.length(), to);
        start_pos += to.length();
    }
    return str;
}

std::vector<std::string> explode(std::string s, std::string delimiter)
{
    if (s.size() == 0) return {};
    int pos_start = 0, pos_end, delim_len = delimiter.length();
    std::string token;
    std::vector<std::string> res;

    while ((pos_end = s.find(delimiter, pos_start)) != std::string::npos)
    {
        token = s.substr(pos_start, pos_end - pos_start);
        pos_start = pos_end + delim_len;
        res.push_back(token);
    }

    res.push_back(s.substr(pos_start));
    return res;
}

std::set<std::string> explodeToSet(std::string str, std::string delimiter)
{
    if (str.size() == 0) return {};
    int pos_start = 0, pos_end, delim_len = delimiter.length();
    std::string token;
    std::set<std::string> res;

    while ((pos_end = str.find(delimiter, pos_start)) != std::string::npos)
    {
        token = str.substr(pos_start, pos_end - pos_start);
        pos_start = pos_end + delim_len;
        res.insert(token);
    }

    res.insert(str.substr(pos_start));
    return res;
}

std::string implode(std::vector<std::string> elements, std::string delimiter)
{
    std::string s;
    for (std::vector<std::string>::iterator ii = elements.begin(); ii != elements.end(); ++ii)
    {
        s += (*ii);
        if (ii + 1 != elements.end())
            s += delimiter;
    }
    return s;
}

bool ends_with(std::string value, std::string ending)
{
    if (value.size() < ending.size())
        return false;
    return std::equal(ending.rbegin(), ending.rend(), value.rbegin());
}

bool starts_with(std::string value, std::string starting)
{
    if (value.size() < starting.size())
        return false;
    return std::equal(starting.begin(), starting.end(), value.begin());
}

uint64_t GetTime()
{
    return std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::system_clock::now().time_since_epoch()).count();
}

std::string str_tolower(std::string s)
{
    std::transform(s.begin(), s.end(), s.begin(), [](unsigned char c)
        { return std::tolower(c); });
    return s;
}

std::string str_toupper(std::string s)
{
    std::transform(s.begin(), s.end(), s.begin(), [](unsigned char c)
        { return std::toupper(c); });
    return s;
}

int32_t genrand()
{
    static std::random_device rd;
    static std::mt19937 rng(rd());
    return std::uniform_int_distribution<int>(0, INT_MAX)(rng);
}

std::string get_uuid()
{
    return fmt::format(
        "{:04x}{:04x}-{:04x}-{:04x}-{:04x}-{:04x}{:04x}{:04x}",
        (genrand() & 0xFFFF), (genrand() & 0xFFFF),
        (genrand() & 0xFFFF),
        ((genrand() & 0x0fff) | 0x4000),
        (genrand() % 0x3fff + 0x8000),
        (genrand() & 0xFFFF), (genrand() & 0xFFFF), (genrand() & 0xFFFF));
}

std::vector<std::string> TokenizeCommand(std::string cmd)
{
    std::vector<std::string> tokens;
    std::string tmp_token;

    bool single_quote = false;
    bool double_quote = false;

    for (const char& c : cmd)
    {
        if (c == '"' && !single_quote) {
            double_quote = !double_quote;
            continue;
        }
        else if (c == '\'' && !double_quote) {
            single_quote = !single_quote;
            continue;
        }

        if (std::isspace(c) && !single_quote && !double_quote) {
            if (!tmp_token.empty()) {
                tokens.push_back(tmp_token);
                tmp_token.clear();
            }
        }
        else {
            tmp_token += c;
        }
    }

    if (!tmp_token.empty())
        tokens.push_back(tmp_token);

    return tokens;
}

void PrintTextTable(LogType type, std::string category, TextTable table)
{
    static auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);

    std::vector<std::string> rows = explode(TableToString(table), "\n");
    for (int i = 0; i < rows.size() - 1; i++)
        logger->Log(type, category, rows[i] + "\n");
}

std::string& rtrim(std::string& s, const char* t)
{
    s.erase(s.find_last_not_of(t) + 1);
    return s;
}

std::string& ltrim(std::string& s, const char* t)
{
    s.erase(0, s.find_first_not_of(t));
    return s;
}

std::string& trim(std::string& s, const char* t)
{
    return ltrim(rtrim(s, t), t);
}

std::string RemoveHtmlTags(std::string input) {
    std::regex pattern("<(/?)(div|font)[^>]*>");

    return std::regex_replace(input, pattern, "");
}