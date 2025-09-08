using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSWeaponBase : IBasePlayerWeapon {

  public ref bool Removeable { get; }
  
  public ref CUtlVector ThirdPersonFireSequences { get; }
  
  public IHSequence CurrentThirdPersonSequence { get; }
  
  public IHSequence ThirdPersonSequences { get; }
  
  public ref bool PlayerAmmoStockOnPickup { get; }
  
  public ref bool RequireUseToTouch { get; }
  
  public ref WeaponGameplayAnimState WeaponGameplayAnimState { get; }
  
  public IGameTime_t WeaponGameplayAnimStateTimestamp { get; }
  
  public IGameTime_t InspectCancelCompleteTime { get; }
  
  public ref bool InspectPending { get; }
  
  public ref bool InspectShouldLoop { get; }
  
  public ref int LastEmptySoundCmdNum { get; }
  
  public ref bool FireOnEmpty { get; }
  
  public IEntityIOOutput OnPlayerPickup { get; }
  
  public ref CSWeaponMode WeaponMode { get; }
  
  public ref float TurningInaccuracyDelta { get; }
  
  public ref Vector TurningInaccuracyEyeDirLast { get; }
  
  public ref float TurningInaccuracy { get; }
  
  public ref float AccuracyPenalty { get; }
  
  public IGameTime_t LastAccuracyUpdateTime { get; }
  
  public ref float AccuracySmoothedForZoom { get; }
  
  public ref int RecoilIndex { get; }
  
  public ref float RecoilIndex { get; }
  
  public ref bool BurstMode { get; }
  
  public IGameTick_t PostponeFireReadyTicks { get; }
  
  public ref float PostponeFireReadyFrac { get; }
  
  public ref bool InReload { get; }
  
  public IGameTime_t DroppedAtTime { get; }
  
  public ref bool IsHauledBack { get; }
  
  public ref bool SilencerOn { get; }
  
  public IGameTime_t TimeSilencerSwitchComplete { get; }
  
  public ref int OriginalTeamNumber { get; }
  
  public ref int MostRecentTeamNumber { get; }
  
  public ref bool DroppedNearBuyZone { get; }
  
  public ref float NextAttackRenderTimeOffset { get; }
  
  public ref bool CanBePickedUp { get; }
  
  public ref bool UseCanOverrideNextOwnerTouchTime { get; }
  
  public IGameTime_t NextOwnerTouchTime { get; }
  
  public IGameTime_t NextPrevOwnerTouchTime { get; }
  
  public IGameTime_t NextPrevOwnerUseTime { get; }
  
  public ref CHandle<CCSPlayerPawn> PrevOwner { get; }
  
  public IGameTick_t DropTick { get; }
  
  public ref bool WasActiveWeaponWhenDropped { get; }
  
  public ref bool Donated { get; }
  
  public IGameTime_t LastShotTime { get; }
  
  public ref bool WasOwnedByCT { get; }
  
  public ref bool WasOwnedByTerrorist { get; }
  
  public ref int NumRemoveUnownedWeaponThink { get; }
  
  public IIronSightController IronSightController { get; }
  
  public ref int IronSightMode { get; }
  
  public IGameTime_t LastLOSTraceFailureTime { get; }
  
  public ref float WatTickOffset { get; }
  
}