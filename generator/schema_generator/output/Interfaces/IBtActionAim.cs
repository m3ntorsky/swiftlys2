using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBtActionAim : IBtNode {

  
  public ref CUtlString SensorInputKey { get; }
  
  public ref CUtlString AimReadyKey { get; }
  
  public ref float ZoomCooldownTimestamp { get; }
  
  public ref bool DoneAiming { get; }
  
  public ref float LerpStartTime { get; }
  
  public ref float NextLookTargetLerpTime { get; }
  
  public ref float PenaltyReductionRatio { get; }
  
  public ref QAngle NextLookTarget { get; }
  
  public ICountdownTimer AimTimer { get; }
  
  public ICountdownTimer SniperHoldTimer { get; }
  
  public ICountdownTimer FocusIntervalTimer { get; }
  
  public ref bool Acquired { get; }
}