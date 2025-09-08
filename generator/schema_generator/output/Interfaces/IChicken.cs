using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IChicken : IDynamicProp {

  public IAttributeContainer AttributeManager { get; }
  
  public ICountdownTimer UpdateTimer { get; }
  
  public ref Vector StuckAnchor { get; }
  
  public ICountdownTimer StuckTimer { get; }
  
  public ICountdownTimer CollisionStuckTimer { get; }
  
  public ref bool IsOnGround { get; }
  
  public ref Vector FallVelocity { get; }
  
  public ref ChickenActivity DesiredActivity { get; }
  
  public ref ChickenActivity CurrentActivity { get; }
  
  public ICountdownTimer ActivityTimer { get; }
  
  public ref float TurnRate { get; }
  
  public CHandle<IBaseEntity> FleeFrom { get; }
  
  public ICountdownTimer MoveRateThrottleTimer { get; }
  
  public ICountdownTimer StartleTimer { get; }
  
  public ICountdownTimer VocalizeTimer { get; }
  
  public IGameTime_t WhenZombified { get; }
  
  public ref bool JumpedThisFrame { get; }
  
  public CHandle<ICSPlayerPawn> Leader { get; }
  
  public ICountdownTimer ReuseTimer { get; }
  
  public ref bool HasBeenUsed { get; }
  
  public ICountdownTimer JumpTimer { get; }
  
  public ref float LastJumpTime { get; }
  
  public ref bool InJump { get; }
  
  public ICountdownTimer RepathTimer { get; }
  
  public ref Vector PathGoal { get; }
  
  public IGameTime_t ActiveFollowStartTime { get; }
  
  public ICountdownTimer FollowMinuteTimer { get; }
  
  public ICountdownTimer BlockDirectionTimer { get; }
  
}