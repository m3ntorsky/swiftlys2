using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysHinge : IPhysConstraint {

  
  public IConstraintSoundInfo SoundInfo { get; }
  
  public IEntityIOOutput NotifyMinLimitReached { get; }
  
  public IEntityIOOutput NotifyMaxLimitReached { get; }
  
  public ref bool AtMinLimit { get; }
  
  public ref bool AtMaxLimit { get; }
  
  public Iconstraint_hingeparams_t Hinge { get; }
  
  public ref float HingeFriction { get; }
  
  public ref float SystemLoadScale { get; }
  
  public ref bool IsAxisLocal { get; }
  
  public ref float MinRotation { get; }
  
  public ref float MaxRotation { get; }
  
  public ref float InitialRotation { get; }
  
  public ref float MotorFrequency { get; }
  
  public ref float MotorDampingRatio { get; }
  
  public ref float AngleSpeed { get; }
  
  public ref float AngleSpeedThreshold { get; }
  
  public IEntityIOOutput OnStartMoving { get; }
  
  public IEntityIOOutput OnStopMoving { get; }
}