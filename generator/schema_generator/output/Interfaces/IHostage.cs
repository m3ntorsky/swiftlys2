using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHostage : IHostageExpresserShim {

  public IEntityIOOutput OnHostageBeginGrab { get; }
  
  public IEntityIOOutput OnFirstPickedUp { get; }
  
  public IEntityIOOutput OnDroppedNotRescued { get; }
  
  public IEntityIOOutput OnRescued { get; }
  
  public IEntitySpottedState_t EntitySpottedState { get; }
  
  public ref int SpotRules { get; }
  
  public ref uint UiHostageSpawnExclusionGroupMask { get; }
  
  public ref uint HostageSpawnRandomFactor { get; }
  
  public ref bool Remove { get; }
  
  public ref Vector Vel { get; }
  
  public ref bool IsRescued { get; }
  
  public ref bool JumpedThisFrame { get; }
  
  public ref int HostageState { get; }
  
  public ref CHandle<CBaseEntity> Leader { get; }
  
  public ref CHandle<CCSPlayerPawnBase> LastLeader { get; }
  
  public ICountdownTimer ReuseTimer { get; }
  
  public ref bool HasBeenUsed { get; }
  
  public ref Vector Accel { get; }
  
  public ref bool IsRunning { get; }
  
  public ref bool IsCrouching { get; }
  
  public ICountdownTimer JumpTimer { get; }
  
  public ref bool IsWaitingForLeader { get; }
  
  public ICountdownTimer RepathTimer { get; }
  
  public ICountdownTimer InhibitDoorTimer { get; }
  
  public ICountdownTimer InhibitObstacleAvoidanceTimer { get; }
  
  public ICountdownTimer WiggleTimer { get; }
  
  public ref bool IsAdjusted { get; }
  
  public ref bool HandsHaveBeenCut { get; }
  
  public ref CHandle<CCSPlayerPawn> HostageGrabber { get; }
  
  public IGameTime_t LastGrabTime { get; }
  
  public ref Vector PositionWhenStartedDroppingToGround { get; }
  
  public ref Vector GrabbedPos { get; }
  
  public IGameTime_t RescueStartTime { get; }
  
  public IGameTime_t GrabSuccessTime { get; }
  
  public IGameTime_t DropStartTime { get; }
  
  public ref int ApproachRewardPayouts { get; }
  
  public ref int PickupEventCount { get; }
  
  public ref Vector SpawnGroundPos { get; }
  
  public ref Vector HostageResetPosition { get; }
  
}