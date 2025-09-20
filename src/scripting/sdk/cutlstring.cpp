/************************************************************************************************
 * SwiftlyS2 is a scripting framework for Source2-based games.
 * Copyright (C) 2025 Swiftly Solution SRL via Sava Andrei-Sebastian and it's contributors
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 ************************************************************************************************/

#include <scripting/scripting.h>
#include <api/interfaces/manager.h>

void Bridge_CUtlString_Set(void* utlstring, const char* str)
{
    ((CUtlString*)utlstring)->Set(str);
}

void Bridge_CUtlString_Purge(void* utlstring)
{
    ((CUtlString*)utlstring)->Purge();
}

void Bridge_CUtlString_SetDirect(void* utlstring, const char* str, int len)
{
    ((CUtlString*)utlstring)->SetDirect(str, len);
}

DEFINE_NATIVE("CUtlString.Set", Bridge_CUtlString_Set);
DEFINE_NATIVE("CUtlString.Purge", Bridge_CUtlString_Purge);
DEFINE_NATIVE("CUtlString.SetDirect", Bridge_CUtlString_SetDirect);