using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSWeaponBase : CBasePlayerWeapon, ICSWeaponBase {

  public CCSWeaponBase(nint handle) : base(handle) {
  }

  public ref bool Removeable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA512A9A0EFD));
  }
  public ref CUtlVector ThirdPersonFireSequences {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x8102BA5146E89B3F));
  }
  public IHSequence CurrentThirdPersonSequence {
    get => new HSequence(_Handle + Schema.GetOffset(0x8102BA517E5CCF19));
  }
  public IHSequence ThirdPersonSequences {
    get => new HSequence(_Handle, 0x8102BA51B96AAFB3, 7, 4, 4);
  }
  public ref bool PlayerAmmoStockOnPickup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA51D64BCF69));
  }
  public ref bool RequireUseToTouch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA51E52ED88D));
  }
  public ref int LastEmptySoundCmdNum {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8102BA513E7E6941));
  }
  public ref bool FireOnEmpty {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA5172D822E5));
  }
  public IEntityIOOutput OnPlayerPickup {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x8102BA51DE81BF25));
  }
  public ref float TurningInaccuracyDelta {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8102BA51C32CA614));
  }
  public ref Vector TurningInaccuracyEyeDirLast {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8102BA51294B9004));
  }
  public ref float TurningInaccuracy {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8102BA51533B6902));
  }
  public IGameTime_t LastAccuracyUpdateTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8102BA514B746ABE));
  }
  public ref float AccuracySmoothedForZoom {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8102BA519B72CD81));
  }
  public ref float NextAttackRenderTimeOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8102BA518D5552CC));
  }
  public ref bool CanBePickedUp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA51BC5DCE9D));
  }
  public ref bool UseCanOverrideNextOwnerTouchTime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA515AD674E8));
  }
  public IGameTime_t NextOwnerTouchTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8102BA51FECB784F));
  }
  public IGameTime_t NextPrevOwnerTouchTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8102BA515C688482));
  }
  public ref bool Donated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA516864DC4A));
  }
  public ref bool WasOwnedByCT {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA5102E58E01));
  }
  public ref bool WasOwnedByTerrorist {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8102BA517A3CE544));
  }
  public ref int NumRemoveUnownedWeaponThink {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8102BA51F8C16A23));
  }
  public IIronSightController IronSightController {
    get => new CIronSightController(_Handle + Schema.GetOffset(0x8102BA5189739F40));
  }
  public IGameTime_t LastLOSTraceFailureTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8102BA51EFA6E48B));
  }

  public void WeaponGameplayAnimStateUpdated() {
    Schema.Update(_Handle, 0x8102BA514CFB8FEA);
  }
  public void WeaponGameplayAnimStateTimestampUpdated() {
    Schema.Update(_Handle, 0x8102BA51180F65AD);
  }
  public void InspectCancelCompleteTimeUpdated() {
    Schema.Update(_Handle, 0x8102BA51A9C029E5);
  }
  public void InspectPendingUpdated() {
    Schema.Update(_Handle, 0x8102BA51793FE8B6);
  }
  public void InspectShouldLoopUpdated() {
    Schema.Update(_Handle, 0x8102BA51CB0DE08A);
  }
  public void WeaponModeUpdated() {
    Schema.Update(_Handle, 0x8102BA51AA0E449E);
  }
  public void AccuracyPenaltyUpdated() {
    Schema.Update(_Handle, 0x8102BA517FB6DE25);
  }
  public void RecoilIndexUpdated() {
    Schema.Update(_Handle, 0x8102BA5191B65146);
  }
  public void RecoilIndexUpdated() {
    Schema.Update(_Handle, 0x8102BA51D779E87B);
  }
  public void BurstModeUpdated() {
    Schema.Update(_Handle, 0x8102BA513016BB7E);
  }
  public void PostponeFireReadyTicksUpdated() {
    Schema.Update(_Handle, 0x8102BA51EF9494E8);
  }
  public void PostponeFireReadyFracUpdated() {
    Schema.Update(_Handle, 0x8102BA51DC2054DC);
  }
  public void InReloadUpdated() {
    Schema.Update(_Handle, 0x8102BA51184F0553);
  }
  public void DroppedAtTimeUpdated() {
    Schema.Update(_Handle, 0x8102BA51C3A8936F);
  }
  public void IsHauledBackUpdated() {
    Schema.Update(_Handle, 0x8102BA51D8C240B9);
  }
  public void SilencerOnUpdated() {
    Schema.Update(_Handle, 0x8102BA5168D3A353);
  }
  public void TimeSilencerSwitchCompleteUpdated() {
    Schema.Update(_Handle, 0x8102BA51DCB190FA);
  }
  public void OriginalTeamNumberUpdated() {
    Schema.Update(_Handle, 0x8102BA515DB51597);
  }
  public void MostRecentTeamNumberUpdated() {
    Schema.Update(_Handle, 0x8102BA51D818821C);
  }
  public void DroppedNearBuyZoneUpdated() {
    Schema.Update(_Handle, 0x8102BA511DC5989F);
  }
  public void NextPrevOwnerUseTimeUpdated() {
    Schema.Update(_Handle, 0x8102BA51C84F06AE);
  }
  public void PrevOwnerUpdated() {
    Schema.Update(_Handle, 0x8102BA5133F3C84D);
  }
  public void DropTickUpdated() {
    Schema.Update(_Handle, 0x8102BA51B2FC22F5);
  }
  public void WasActiveWeaponWhenDroppedUpdated() {
    Schema.Update(_Handle, 0x8102BA51E6BC2F96);
  }
  public void LastShotTimeUpdated() {
    Schema.Update(_Handle, 0x8102BA517A37978C);
  }
  public void IronSightModeUpdated() {
    Schema.Update(_Handle, 0x8102BA51AAF66648);
  }
  public void WatTickOffsetUpdated() {
    Schema.Update(_Handle, 0x8102BA519F5B6237);
  }
}