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

#ifndef src_api_engine_convars_convars_h
#define src_api_engine_convars_convars_h

#include <string>
#include <functional>
#include <variant>

#include <public/tier1/convar.h>
#include <public/mathlib/vector2d.h>
#include <public/mathlib/vector.h>
#include <public/mathlib/vector4d.h>

using ConvarValue = std::variant<int16_t, uint16_t, int32_t, uint32_t, int64_t, uint64_t, bool, float, double, Color, Vector2D, Vector, Vector4D, QAngle, std::string>;

class IConvarManager
{
public:
    virtual void Initialize() = 0;
    virtual void Shutdown() = 0;

    virtual void CreateConvar(std::string cvar_name, EConVarType type, uint64_t flags, const char* help_message, ConvarValue defaultValue) = 0;
    virtual void DeleteConvar(std::string cvar_name) = 0;
    virtual bool ExistsConvar(std::string cvar_name) = 0;

    virtual void* GetConvarDataAddress(std::string cvar_name) = 0;
    virtual ConvarValue GetConvarValue(std::string cvar_name) = 0;

    virtual void SetConvarValue(std::string cvar_name, ConvarValue value) = 0;
    virtual void SetClientConvar(int playerid, std::string cvar_name, ConvarValue value) = 0;
};

#endif