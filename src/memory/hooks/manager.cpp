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

#include "manager.h"

void HooksManager::Initialize()
{
}

void HooksManager::Shutdown()
{
}

IFunctionHook* HooksManager::CreateFunctionHook()
{
    return new FunctionHook();
}

IVFunctionHook* HooksManager::CreateVFunctionHook()
{
    return new VFunctionHook();
}

dyno::DataObject GetDataObject(char arg)
{
    if (arg == 'p')
        return dyno::DataObject(dyno::DataType::Pointer);
    else if (arg == 'f')
        return dyno::DataObject(dyno::DataType::Float);
    else if (arg == 'b')
        return dyno::DataObject(dyno::DataType::Bool);
    else if (arg == 'd')
        return dyno::DataObject(dyno::DataType::Double);
    else if (arg == 'i')
        return dyno::DataObject(dyno::DataType::Int32);
    else if (arg == 'u')
        return dyno::DataObject(dyno::DataType::UInt32);
    else if (arg == 's')
        return dyno::DataObject(dyno::DataType::String);
    else if (arg == 'I')
        return dyno::DataObject(dyno::DataType::Int64);
    else if (arg == 'U')
        return dyno::DataObject(dyno::DataType::UInt64);
    else if (arg == 'v')
        return dyno::DataObject(dyno::DataType::Void);
    else
        return dyno::DataObject(dyno::DataType::Pointer);
}

std::vector<dyno::DataObject> GetDataObjectList(std::string args)
{
    std::vector<dyno::DataObject> objects;

    for (const char& arg : args)
        objects.push_back(GetDataObject(arg));

    return objects;
}