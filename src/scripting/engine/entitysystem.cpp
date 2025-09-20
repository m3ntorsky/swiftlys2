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

#include <api/interfaces/manager.h>
#include <scripting/scripting.h>

#include <entityhandle.h>

void Bridge_EntitySystem_Spawn(void* pEntity, void* pKeyValues)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->Spawn(pEntity, pKeyValues);
}

void Bridge_EntitySystem_Despawn(void* pEntity)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->Despawn(pEntity);
}

void* Bridge_EntitySystem_CreateEntityByName(const char* name)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    return entsystem->CreateEntityByName(name);
}

void Bridge_EntitySystem_AcceptInputInt32(void* pEntity, const char* input, void* pActivator, void* pCaller, int32_t value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AcceptInputUInt32(void* pEntity, const char* input, void* pActivator, void* pCaller, uint32_t value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AcceptInputInt64(void* pEntity, const char* input, void* pActivator, void* pCaller, int64_t value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AcceptInputUInt64(void* pEntity, const char* input, void* pActivator, void* pCaller, uint64_t value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AcceptInputFloat(void* pEntity, const char* input, void* pActivator, void* pCaller, float value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AcceptInputDouble(void* pEntity, const char* input, void* pActivator, void* pCaller, double value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AcceptInputBool(void* pEntity, const char* input, void* pActivator, void* pCaller, bool value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AcceptInputString(void* pEntity, const char* input, void* pActivator, void* pCaller, const char* value, int32_t outputID)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AcceptInput(pEntity, input, pActivator, pCaller, value, outputID);
}

void Bridge_EntitySystem_AddEntityIOEventInt32(void* pEntity, const char* input, void* pActivator, void* pCaller, int32_t value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

void Bridge_EntitySystem_AddEntityIOEventUInt32(void* pEntity, const char* input, void* pActivator, void* pCaller, uint32_t value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

void Bridge_EntitySystem_AddEntityIOEventInt64(void* pEntity, const char* input, void* pActivator, void* pCaller, int64_t value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

void Bridge_EntitySystem_AddEntityIOEventUInt64(void* pEntity, const char* input, void* pActivator, void* pCaller, uint64_t value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

void Bridge_EntitySystem_AddEntityIOEventFloat(void* pEntity, const char* input, void* pActivator, void* pCaller, float value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

void Bridge_EntitySystem_AddEntityIOEventDouble(void* pEntity, const char* input, void* pActivator, void* pCaller, double value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

void Bridge_EntitySystem_AddEntityIOEventBool(void* pEntity, const char* input, void* pActivator, void* pCaller, bool value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

void Bridge_EntitySystem_AddEntityIOEventString(void* pEntity, const char* input, void* pActivator, void* pCaller, const char* value, float delay)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entsystem->AddEntityIOEvent(pEntity, input, pActivator, pCaller, value, delay);
}

bool Bridge_EntitySystem_IsValidEntity(void* pEntity)
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    return entsystem->IsValidEntity(pEntity);
}

void* Bridge_EntitySystem_GetGameRules()
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    return entsystem->GetGameRules();
}

void* Bridge_EntitySystem_GetEntitySystem()
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    return entsystem->GetEntitySystem();
}


void* Bridge_EntitySystem_GetFirstActiveEntity()
{
    auto entsystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    return entsystem->GetEntitySystem()->m_EntityList.m_pFirstActiveEntity;
}


bool Bridge_EntitySystem_EntityHandleIsValid(uint32 ihandle)
{
    CEntityHandle handle(ihandle);
    return handle.IsValid() && handle.Get() != nullptr;
}

void* Bridge_EntitySystem_EntityHandleGet(uint32 ihandle)
{
    CEntityHandle handle(ihandle);
    return handle.Get();
}

int Bridge_EntitySystem_GetEntityHandleFromEntity(CEntityInstance* pEntity)
{
    return pEntity->GetRefEHandle().ToInt();
}

DEFINE_NATIVE("EntitySystem.Spawn", Bridge_EntitySystem_Spawn);
DEFINE_NATIVE("EntitySystem.Despawn", Bridge_EntitySystem_Despawn);
DEFINE_NATIVE("EntitySystem.CreateEntityByName", Bridge_EntitySystem_CreateEntityByName);
DEFINE_NATIVE("EntitySystem.AcceptInputInt32", Bridge_EntitySystem_AcceptInputInt32);
DEFINE_NATIVE("EntitySystem.AcceptInputUInt32", Bridge_EntitySystem_AcceptInputUInt32);
DEFINE_NATIVE("EntitySystem.AcceptInputInt64", Bridge_EntitySystem_AcceptInputInt64);
DEFINE_NATIVE("EntitySystem.AcceptInputUInt64", Bridge_EntitySystem_AcceptInputUInt64);
DEFINE_NATIVE("EntitySystem.AcceptInputFloat", Bridge_EntitySystem_AcceptInputFloat);
DEFINE_NATIVE("EntitySystem.AcceptInputDouble", Bridge_EntitySystem_AcceptInputDouble);
DEFINE_NATIVE("EntitySystem.AcceptInputBool", Bridge_EntitySystem_AcceptInputBool);
DEFINE_NATIVE("EntitySystem.AcceptInputString", Bridge_EntitySystem_AcceptInputString);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventInt32", Bridge_EntitySystem_AddEntityIOEventInt32);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventUInt32", Bridge_EntitySystem_AddEntityIOEventUInt32);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventInt64", Bridge_EntitySystem_AddEntityIOEventInt64);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventUInt64", Bridge_EntitySystem_AddEntityIOEventUInt64);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventFloat", Bridge_EntitySystem_AddEntityIOEventFloat);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventDouble", Bridge_EntitySystem_AddEntityIOEventDouble);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventBool", Bridge_EntitySystem_AddEntityIOEventBool);
DEFINE_NATIVE("EntitySystem.AddEntityIOEventString", Bridge_EntitySystem_AddEntityIOEventString);
DEFINE_NATIVE("EntitySystem.IsValidEntity", Bridge_EntitySystem_IsValidEntity);
DEFINE_NATIVE("EntitySystem.GetGameRules", Bridge_EntitySystem_GetGameRules);
DEFINE_NATIVE("EntitySystem.GetEntitySystem", Bridge_EntitySystem_GetEntitySystem);
DEFINE_NATIVE("EntitySystem.EntityHandleIsValid", Bridge_EntitySystem_EntityHandleIsValid);
DEFINE_NATIVE("EntitySystem.EntityHandleGet", Bridge_EntitySystem_EntityHandleGet);
DEFINE_NATIVE("EntitySystem.GetEntityHandleFromEntity", Bridge_EntitySystem_GetEntityHandleFromEntity);
DEFINE_NATIVE("EntitySystem.GetFirstActiveEntity", Bridge_EntitySystem_GetFirstActiveEntity);