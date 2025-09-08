using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncRotator : IBaseModelEntity {

  public CHandle<IBaseEntity> RotatorTarget { get; }
  
  public ref bool IsRotating { get; }
  
  public ref bool IsReversing { get; }
  
  public ref float TimeToReachMaxSpeed { get; }
  
  public ref float TimeToReachZeroSpeed { get; }
  
  public ref float DistanceAlongArcTraveled { get; }
  
  public ref float TimeToWaitOscillate { get; }
  
  public IGameTime_t TimeRotationStart { get; }
  
  public ref Quaternion LSPrevChange { get; }
  
  public ref Quaternion WSPrev { get; }
  
  public ref Quaternion WSInit { get; }
  
  public ref Quaternion LSInit { get; }
  
  public ref Quaternion LSOrientation { get; }
  
  public IEntityIOOutput OnRotationStarted { get; }
  
  public IEntityIOOutput OnRotationCompleted { get; }
  
  public IEntityIOOutput OnOscillate { get; }
  
  public IEntityIOOutput OnOscillateStartArrive { get; }
  
  public IEntityIOOutput OnOscillateStartDepart { get; }
  
  public IEntityIOOutput OnOscillateEndArrive { get; }
  
  public IEntityIOOutput OnOscillateEndDepart { get; }
  
  public ref bool OscillateDepart { get; }
  
  public ref int OscillateCount { get; }
  
  public ref CFuncRotator::Rotate_t RotateType { get; }
  
  public ref CFuncRotator::Rotate_t PrevRotateType { get; }
  
  public ref bool HasTargetOverride { get; }
  
  public ref Quaternion OrientationOverride { get; }
  
  public ref RotatorTargetSpace_t SpaceOverride { get; }
  
  public ref QAngle AngularVelocity { get; }
  
  public ref Vector LookAtForcedUp { get; }
  
  public ref CUtlSymbolLarge StrRotatorTarget { get; }
  
  public ref bool RecordHistory { get; }
  
  public ref CUtlVector RotatorHistory { get; }
  
  public ref bool ReturningToPreviousOrientation { get; }
  
  public ref CUtlVector RotatorQueue { get; }
  
  public ref CUtlVector RotatorQueueHistory { get; }
  
}