using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBasePlayerPawn : CBaseCombatCharacter, IBasePlayerPawn {

  public CBasePlayerPawn(nint handle) : base(handle) {
  }

  public ref QAngle V_angle {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xCA2EED0413C45A71));
  }
  public ref QAngle V_anglePrevious {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xCA2EED0406B54DD4));
  }
  public IGameTime_t TimeLastHurt {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xCA2EED048FA4AFB1));
  }
  public IGameTime_t NextSuicideTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xCA2EED04735FDC79));
  }
  public ref bool InitHUD {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCA2EED04BA12A114));
  }
  public IAI_Expresser Expresser {
    get => new CAI_Expresser(_Handle + Schema.GetOffset(0xCA2EED04697CAC2A));
  }
  public ref float HltvReplayDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCA2EED043108CD5F));
  }
  public ref float HltvReplayEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCA2EED0479F16CD5));
  }
  public ref CEntityIndex HltvReplayEntity {
    get => ref _Handle.AsRef<CEntityIndex>(Schema.GetOffset(0xCA2EED04ADF32E26));
  }
  public ref CUtlVector SndOpvarLatchData {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xCA2EED046B36858E));
  }

  public void WeaponServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED0451B23A93);
  }
  public void ItemServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED04AABBB9B8);
  }
  public void AutoaimServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED0413209115);
  }
  public void ObserverServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED044ED1A579);
  }
  public void WaterServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED04A5653452);
  }
  public void UseServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED04A87C910A);
  }
  public void FlashlightServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED046CF76641);
  }
  public void CameraServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED043B7DFD20);
  }
  public void MovementServicesUpdated() {
    Schema.Update(_Handle, 0xCA2EED04CF73E28A);
  }
  public void ServerViewAngleChangesUpdated() {
    Schema.Update(_Handle, 0xCA2EED049182F3B7);
  }
  public void HideHUDUpdated() {
    Schema.Update(_Handle, 0xCA2EED040627E4A5);
  }
  public void Skybox3dUpdated() {
    Schema.Update(_Handle, 0xCA2EED0451DA4DBC);
  }
  public void DeathTimeUpdated() {
    Schema.Update(_Handle, 0xCA2EED0407F7A70A);
  }
  public void ControllerUpdated() {
    Schema.Update(_Handle, 0xCA2EED0429882A6B);
  }
  public void DefaultControllerUpdated() {
    Schema.Update(_Handle, 0xCA2EED04A623A4A8);
  }
}