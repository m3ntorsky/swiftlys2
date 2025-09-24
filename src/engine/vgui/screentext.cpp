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

#include "screentext.h"

#include <api/interfaces/manager.h>

#include <api/memory/virtual/call.h>

#include <public/entity2/entitykeyvalues.h>

void CScreenText::Create(Color color, const std::string& font, int size, bool drawBackground, bool isMenu)
{
    m_col = color;
    m_font = font;
    m_size = size;
    m_drawBackground = drawBackground;
    m_isMenu = isMenu;

    static auto entitysystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);

    pScreenEntity.Set((CEntityInstance*)(entitysystem->CreateEntityByName("point_worldtext")));
    if (!pScreenEntity) return;

    CEntityKeyValues* pMenuKV = new CEntityKeyValues();

    pMenuKV->SetBool("enabled", true);
    pMenuKV->SetFloat("world_units_per_pixel", (0.25 / 1050) * size);
    pMenuKV->SetInt("justify_horizontal", 0);
    pMenuKV->SetInt("justify_vertical", 2);
    pMenuKV->SetInt("reorient_mode", 0);
    pMenuKV->SetInt("fullbright", 1);
    pMenuKV->SetFloat("font_size", size);
    pMenuKV->SetString("font_name", font.c_str());
    pMenuKV->SetColor("color", color);

    if (drawBackground) {
        pMenuKV->SetBool("draw_background", true);

        if (isMenu) {
            pMenuKV->SetFloat("background_border_width", 0.2);
            pMenuKV->SetFloat("background_border_height", 0.15);
        }
        else {
            static auto config = g_ifaceService.FetchInterface<IConfiguration>(CONFIGURATION_INTERFACE_VERSION);
            pMenuKV->SetFloat("background_border_width", 0.1f);
            pMenuKV->SetFloat("background_border_height", 0.1f);
        }

        pMenuKV->SetFloat("background_away_units", 0.04);
        pMenuKV->SetFloat("background_world_to_uv", 0.05);
    }

    entitysystem->Spawn(pScreenEntity.Get(), pMenuKV);
}

void CScreenText::SetupViewForPlayer(IPlayer* player)
{
    m_player = player;

    if (!pScreenEntity.IsValid()) return;
    if (!pScreenEntity) return;

    if (!player) return;
    if (player->IsFakeClient()) return;

    static auto entitysystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entitysystem->AcceptInput(pScreenEntity.Get(), "SetParent", player->GetPawn(), nullptr, "!activator", 0);
    entitysystem->AcceptInput(pScreenEntity.Get(), "SetParentAttachmentMaintainOffset", nullptr, nullptr, "axis_of_intent", 0);
}

void CScreenText::SetText(const std::string& text)
{
    m_text = text;

    if (!pScreenEntity.IsValid()) return;
    if (!pScreenEntity) return;

    static auto entitysystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
    entitysystem->AcceptInput(pScreenEntity.Get(), "SetMessage", nullptr, nullptr, text.c_str(), 0);
    entitysystem->AcceptInput(pScreenEntity.Get(), "Enable", nullptr, nullptr, "", 0);
}

void CScreenText::SetPosition(float posX, float posY)
{
    m_posX = posX;
    m_posY = posY;

    if (!m_player) return;
    if (m_player->IsFakeClient()) return;
    if (!pScreenEntity.IsValid()) return;
    if (!pScreenEntity) return;

    auto pawn = m_player->GetPlayerPawn();
    if (!pawn) return;

    static auto schema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);

    if (*(uint32_t*)schema->GetPropPtr(pawn, "CBaseEntity", "m_lifeState") == 2) {
        auto controller = m_player->GetController();
        if (!controller) return;
        if (*(bool*)schema->GetPropPtr(controller, "CCSPlayerController", "m_bControllingBot")) return;

        auto observerServices = *(void**)schema->GetPropPtr(pawn, "CBasePlayerPawn", "m_pObserverServices");
        if (!observerServices) return;

        CHandle<CEntityInstance> observerTarget = *(CHandle<CEntityInstance>*)schema->GetPropPtr(observerServices, "CPlayer_ObserverServices", "m_hObserverTarget");
        if (!observerTarget) return;

        auto observerController = *(CHandle<CEntityInstance>*)schema->GetPropPtr(observerTarget.Get(), "CCSPlayerPawnBase", "m_hOriginalController");
        if (!observerController) return;

        CHandle<CEntityInstance> pawnHandle = *(CHandle<CEntityInstance>*)schema->GetPropPtr(observerController, "CCSPlayerController", "m_hPlayerPawn");
        if (!pawnHandle) return;
        pawn = (void*)(pawnHandle.Get());
    }

    if (!pawn) return;

    QAngle eyeAngles = *(QAngle*)schema->GetPropPtr(pawn, "CCSPlayerPawn", "m_angEyeAngles");

    void* bodyComponent = *(void**)schema->GetPropPtr(pawn, "CBaseEntity", "m_CBodyComponent");
    if (!bodyComponent) return;

    void* sceneNode = *(void**)schema->GetPropPtr(bodyComponent, "CBodyComponent", "m_pSceneNode");
    if (!sceneNode) return;

    void* camServices = *(void**)schema->GetPropPtr(pawn, "CBasePlayerPawn", "m_pCameraServices");
    if (!camServices) return;

    float oldZ = *(float*)schema->GetPropPtr(camServices, "CPlayer_CameraServices", "m_flOldPlayerViewOffsetZ");

    Vector fwd, right, up;
    AngleVectors(eyeAngles, &fwd, &right, &up);

    Vector eyePos(0.0, 0.0, 0.0);
    eyePos += fwd * 54;
    eyePos += right * (-9.2);
    eyePos += up * (-4.9);

    QAngle ang(0, eyeAngles.y + 270, 90 - eyeAngles.x);

    Vector origin = *(Vector*)schema->GetPropPtr(sceneNode, "CGameSceneNode", "m_vecAbsOrigin");
    eyePos += origin + Vector(0, 0, oldZ);

    static auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);
    CALL_VIRTUAL(void, gamedata->GetOffsets()->Fetch("CBaseEntity::Teleport"), pScreenEntity.Get(), &eyePos, &ang, nullptr);
}

void CScreenText::SetColor(Color color)
{
    m_col = color;

    if (!pScreenEntity.IsValid()) return;
    if (!pScreenEntity) return;

    static auto schema = g_ifaceService.FetchInterface<ISDKSchema>(SDKSCHEMA_INTERFACE_VERSION);
    Color& col = *(Color*)schema->GetPropPtr(pScreenEntity.Get(), "CPointWorldText", "m_Color");
    col = color;
}

bool CScreenText::IsValidEntity()
{
    return pScreenEntity.IsValid();
}

void CScreenText::RegenerateText(bool recreate)
{
    if (recreate) {
        static auto entitysystem = g_ifaceService.FetchInterface<IEntitySystem>(ENTITYSYSTEM_INTERFACE_VERSION);
        if (pScreenEntity.IsValid()) entitysystem->Despawn(pScreenEntity.Get());

        Create(m_col, m_font, m_size, m_drawBackground, m_isMenu);
        SetupViewForPlayer(m_player);
        SetText(m_text);
        SetPosition(m_posX, m_posY);
    }
    else {
        SetupViewForPlayer(m_player);
        SetPosition(m_posX, m_posY);
    }
}

IPlayer* CScreenText::GetPlayer()
{
    return m_player;
}

int CScreenText::GetEntityIndex()
{
    if (!pScreenEntity.IsValid()) return 0;
    if (!pScreenEntity) return 0;

    return pScreenEntity->GetEntityIndex().Get();
}

bool CScreenText::IsRenderingTo(CHandle<CEntityInstance> renderingTo)
{
    return renderingTo == pRenderingTo;
}

void CScreenText::SetRenderingTo(CEntityInstance* ent)
{
    pRenderingTo.Set(ent);
}

void CScreenText::ResetSpawnState()
{
    pScreenEntity.Term();
}