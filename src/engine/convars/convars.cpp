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

#include "convars.h"

#include <api/interfaces/manager.h>
#include <api/sdk/recipientfilter.h>
#include <api/sdk/serversideclient.h>

#include <memory/gamedata/manager.h>

#include <public/networksystem/inetworkmessages.h>
#include <public/engine/igameeventsystem.h>

#include <format>

#include "networkbasetypes.pb.h"

#define NEW_CVAR(data_type, default_value) \
    cvarptr = (void*)(new CConVar<data_type>(cvar_name.c_str(), flags, help_message, std::get<data_type>(defaultValue)))

#define FREE_CVAR(data_type) \
    delete (CConVar<data_type>*)cvarptr;

std::map<std::string, void*> g_mCvars;
uint64_t g_uQueryCallbacks = 0;
std::map<uint64_t, std::function<void(int, std::string, std::string)>> g_mQueryCallbacks;

void CConvarManager::Initialize()
{
}

void CConvarManager::Shutdown()
{
}

void CConvarManager::QueryClientConvar(int playerid, std::string cvar_name)
{
    auto networkMessages = g_ifaceService.FetchInterface<INetworkMessages>(NETWORKMESSAGES_INTERFACE_VERSION);
    auto gameEventSystem = g_ifaceService.FetchInterface<IGameEventSystem>(GAMEEVENTSYSTEM_INTERFACE_VERSION);

    auto netmsg = networkMessages->FindNetworkMessagePartial("GetCvarValue");
    auto msg = netmsg->AllocateMessage()->ToPB<CSVCMsg_GetCvarValue>();

    msg->set_cvar_name(cvar_name);

    CSingleRecipientFilter filter(playerid);
    gameEventSystem->PostEventAbstract(-1, false, &filter, netmsg, msg, 0);

    // see at the end of the file the comment for this one too
    delete msg;
}

int CConvarManager::AddQueryClientCvarCallback(std::function<void(int, std::string, std::string)> callback)
{
    g_mQueryCallbacks[g_uQueryCallbacks++] = callback;
    return g_uQueryCallbacks - 1;
}

void CConvarManager::RemoveQueryClientCvarCallback(int callback_id)
{
    g_mQueryCallbacks.erase(callback_id);
}

void CConvarManager::OnClientQueryCvar(int playerid, std::string cvar_name, std::string cvar_value)
{
    for (const auto& [id, callback] : g_mQueryCallbacks)
    {
        callback(playerid, cvar_name, cvar_value);
    }
}

void CConvarManager::CreateConvar(std::string cvar_name, EConVarType type, uint64_t flags, const char* help_message, ConvarValue defaultValue)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    if (cvar.IsValidRef()) return;

    void* cvarptr = nullptr;
    if (type == EConVarType_Int16)
    {
        NEW_CVAR(int16_t, 0);
    }
    else if (type == EConVarType_UInt16)
    {
        NEW_CVAR(uint16_t, 0);
    }
    else if (type == EConVarType_UInt32)
    {
        NEW_CVAR(uint32_t, 0);
    }
    else if (type == EConVarType_Int32)
    {
        NEW_CVAR(int32_t, 0);
    }
    else if (type == EConVarType_UInt64)
    {
        NEW_CVAR(uint64_t, 0);
    }
    else if (type == EConVarType_Int64)
    {
        NEW_CVAR(int64_t, 0);
    }
    else if (type == EConVarType_Bool)
    {
        NEW_CVAR(bool, false);
    }
    else if (type == EConVarType_Float32)
    {
        NEW_CVAR(float, 0.0f);
    }
    else if (type == EConVarType_Float64)
    {
        NEW_CVAR(double, 0.0);
    }
    else if (type == EConVarType_Color)
    {
        NEW_CVAR(Color, Color(0, 0, 0, 255));
    }
    else if (type == EConVarType_Vector2)
    {
        NEW_CVAR(Vector2D, Vector2D(0, 0));
    }
    else if (type == EConVarType_Vector3)
    {
        NEW_CVAR(Vector, Vector(0, 0, 0));
    }
    else if (type == EConVarType_Vector4)
    {
        NEW_CVAR(Vector4D, Vector4D(0, 0, 0, 0));
    }
    else if (type == EConVarType_Qangle)
    {
        NEW_CVAR(QAngle, QAngle(0, 0, 0));
    }
    else if (type == EConVarType_String)
    {
        auto v = std::get<std::string>(defaultValue);
        cvarptr = (void*)(new CConVar<CUtlString>(cvar_name.c_str(), flags, help_message, CUtlString(v.c_str())));
    }

    if (!cvarptr) return;
    g_mCvars[cvar_name] = cvarptr;
}

void CConvarManager::DeleteConvar(std::string cvar_name)
{
    if (g_mCvars.find(cvar_name) == g_mCvars.end()) return;

    void* cvarptr = g_mCvars.at(cvar_name);
    ConVarRefAbstract cvar(cvar_name.c_str());

    if (cvar.GetType() == EConVarType_Int16)
    {
        FREE_CVAR(int16);
    }
    else if (cvar.GetType() == EConVarType_UInt16)
    {
        FREE_CVAR(uint16);
    }
    else if (cvar.GetType() == EConVarType_UInt32)
    {
        FREE_CVAR(uint32);
    }
    else if (cvar.GetType() == EConVarType_Int32)
    {
        FREE_CVAR(int32);
    }
    else if (cvar.GetType() == EConVarType_UInt64)
    {
        FREE_CVAR(uint64);
    }
    else if (cvar.GetType() == EConVarType_Int64)
    {
        FREE_CVAR(int64);
    }
    else if (cvar.GetType() == EConVarType_Bool)
    {
        FREE_CVAR(bool);
    }
    else if (cvar.GetType() == EConVarType_Float32)
    {
        FREE_CVAR(float);
    }
    else if (cvar.GetType() == EConVarType_Float64)
    {
        FREE_CVAR(double);
    }
    else if (cvar.GetType() == EConVarType_String)
    {
        FREE_CVAR(CUtlString);
    }
    else if (cvar.GetType() == EConVarType_Color)
    {
        FREE_CVAR(Color);
    }
    else if (cvar.GetType() == EConVarType_Vector2)
    {
        FREE_CVAR(Vector2D);
    }
    else if (cvar.GetType() == EConVarType_Vector3)
    {
        FREE_CVAR(Vector);
    }
    else if (cvar.GetType() == EConVarType_Vector4)
    {
        FREE_CVAR(Vector4D);
    }
    else if (cvar.GetType() == EConVarType_Qangle)
    {
        FREE_CVAR(QAngle);
    }
    else
    {
        free(cvarptr);
    }

    g_mCvars.erase(cvar_name);
}

bool CConvarManager::ExistsConvar(std::string cvar_name)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    return cvar.IsValidRef() && cvar.IsConVarDataValid();
}

EConVarType CConvarManager::GetConvarType(std::string cvar_name)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    if (!cvar.IsConVarDataValid()) return EConVarType::EConVarType_Invalid;
    return cvar.GetType();
}

void* CConvarManager::GetConvarDataAddress(std::string cvar_name)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    CSplitScreenSlot server(0);
    if (!cvar.IsValidRef()) return nullptr;
    if (!cvar.IsConVarDataValid()) return nullptr;

    return cvar.GetConVarData()->ValueOrDefault(server);
}

ConvarValue CConvarManager::GetConvarValue(std::string cvar_name)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    CSplitScreenSlot server(0);
    if (!cvar.IsConVarDataValid()) return 0;

    if (cvar.GetType() == EConVarType_Int16)
    {
        return cvar.GetAs<int16_t>(server);
    }
    else if (cvar.GetType() == EConVarType_UInt16)
    {
        return cvar.GetAs<uint16_t>(server);
    }
    else if (cvar.GetType() == EConVarType_UInt32)
    {
        return cvar.GetAs<uint32_t>(server);
    }
    else if (cvar.GetType() == EConVarType_Int32)
    {
        return cvar.GetAs<int32_t>(server);
    }
    else if (cvar.GetType() == EConVarType_UInt64)
    {
        return cvar.GetAs<uint64_t>(server);
    }
    else if (cvar.GetType() == EConVarType_Int64)
    {
        return cvar.GetAs<int64_t>(server);
    }
    else if (cvar.GetType() == EConVarType_Bool)
    {
        return cvar.GetAs<bool>(server);
    }
    else if (cvar.GetType() == EConVarType_Float32)
    {
        return cvar.GetAs<float>(server);
    }
    else if (cvar.GetType() == EConVarType_Float64)
    {
        return cvar.GetAs<double>(server);
    }
    else if (cvar.GetType() == EConVarType_String)
    {
        return std::string(cvar.GetString(server).String());
    }
    else if (cvar.GetType() == EConVarType_Color)
    {
        return cvar.GetAs<Color>(server);
    }
    else if (cvar.GetType() == EConVarType_Vector2)
    {
        return cvar.GetAs<Vector2D>(server);
    }
    else if (cvar.GetType() == EConVarType_Vector3)
    {
        return cvar.GetAs<Vector>(server);
    }
    else if (cvar.GetType() == EConVarType_Vector4)
    {
        return cvar.GetAs<Vector4D>(server);
    }
    else if (cvar.GetType() == EConVarType_Qangle)
    {
        return cvar.GetAs<QAngle>(server);
    }
    else {
        static auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);
        logger->Error("Convars", std::format("Unsupported ConVar type: {}", (int)cvar.GetType()));
        return 0;
    }
}

std::string ConvertConvarValueToString(ConvarValue& value)
{
    std::string value_str;
    if (std::holds_alternative<int16_t>(value))
        value_str = std::format("{}", std::get<int16_t>(value));
    else if (std::holds_alternative<uint16_t>(value))
        value_str = std::format("{}", std::get<uint16_t>(value));
    else if (std::holds_alternative<int32_t>(value))
        value_str = std::format("{}", std::get<int32_t>(value));
    else if (std::holds_alternative<uint32_t>(value))
        value_str = std::format("{}", std::get<uint32_t>(value));
    else if (std::holds_alternative<float>(value))
        value_str = std::format("{}", std::get<float>(value));
    else if (std::holds_alternative<double>(value))
        value_str = std::format("{}", std::get<double>(value));
    else if (std::holds_alternative<int64_t>(value))
        value_str = std::format("{}", std::get<int64_t>(value));
    else if (std::holds_alternative<uint64_t>(value))
        value_str = std::format("{}", std::get<uint64_t>(value));
    else if (std::holds_alternative<std::string>(value))
        value_str = std::get<std::string>(value);
    else if (std::holds_alternative<bool>(value))
        value_str = std::get<bool>(value) ? "1" : "0";
    else if (std::holds_alternative<Color>(value))
    {
        Color clr = std::get<Color>(value);
        value_str = std::format("{},{},{},{}", clr.r(), clr.g(), clr.b(), clr.a());
    }
    else if (std::holds_alternative<Vector2D>(value))
    {
        Vector2D vec = std::get<Vector2D>(value);
        value_str = std::format("{},{}", vec.x, vec.y);
    }
    else if (std::holds_alternative<Vector>(value))
    {
        Vector vec = std::get<Vector>(value);
        value_str = std::format("{},{},{}", vec.x, vec.y, vec.z);
    }
    else if (std::holds_alternative<Vector4D>(value))
    {
        Vector4D vec = std::get<Vector4D>(value);
        value_str = std::format("{},{},{},{}", vec.x, vec.y, vec.z, vec.w);
    }
    else if (std::holds_alternative<QAngle>(value))
    {
        QAngle ang = std::get<QAngle>(value);
        value_str = std::format("{},{},{}", ang.x, ang.y, ang.z);
    }
    else value_str = "";

    return value_str;
}


void CConvarManager::SetConvarValue(std::string cvar_name, ConvarValue value)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    CSplitScreenSlot server(0);
    if (!cvar.IsConVarDataValid()) return;

    auto v_str = ConvertConvarValueToString(value);
    cvar.SetString(CUtlString(v_str.c_str()), server);
}

void CConvarManager::SetClientConvar(int playerid, std::string cvar_name, ConvarValue value)
{
    auto networkMessages = g_ifaceService.FetchInterface<INetworkMessages>(NETWORKMESSAGES_INTERFACE_VERSION);
    auto gameEventSystem = g_ifaceService.FetchInterface<IGameEventSystem>(GAMEEVENTSYSTEM_INTERFACE_VERSION);

    auto netmsg = networkMessages->FindNetworkMessagePartial("SetConVar");
    auto msg = netmsg->AllocateMessage()->ToPB<CNETMsg_SetConVar>();

    CMsg_CVars_CVar* cvar = msg->mutable_convars()->add_cvars();
    cvar->set_name(cvar_name);
    cvar->set_value(ConvertConvarValueToString(value));

    CSingleRecipientFilter filter(playerid);
    gameEventSystem->PostEventAbstract(-1, false, &filter, netmsg, msg, 0);

    /*
    Finally it's been fixed, i've had this problem since a year ago, glad that it's fixed and i didn't need to use deamberd with it's "const const const" feature

    thanks memoverride, glad to have you here m8

    now i can finally delete it, even on windows!!!

    and 100% (i'm not sure of this number) i'll not need to stay again 4 hours to debug it

    fuck you windows
    */
    delete msg;
}

/*

it feels so good to not make "#define private public" stuff

some people don't even want to look through all the fields and just go to the shortest way

*/

void CConvarManager::AddFlags(std::string cvar_name, uint64_t flags)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    if (!cvar.IsConVarDataValid()) return;

    cvar.AddFlags(flags);
}

void CConvarManager::RemoveFlags(std::string cvar_name, uint64_t flags)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    if (!cvar.IsConVarDataValid()) return;

    cvar.RemoveFlags(flags);
}

void CConvarManager::ClearFlags(std::string cvar_name)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    if (!cvar.IsConVarDataValid()) return;

    cvar.RemoveFlags(cvar.GetFlags());
}

uint64_t CConvarManager::GetFlags(std::string cvar_name)
{
    ConVarRefAbstract cvar(cvar_name.c_str());
    if (!cvar.IsConVarDataValid()) return 0;

    return cvar.GetFlags();
}
