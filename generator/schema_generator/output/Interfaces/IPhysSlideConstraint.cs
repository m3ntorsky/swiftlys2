using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSlideConstraint : IPhysConstraint {

  
  public ref Vector AxisEnd { get; }
  
  public ref float SlideFriction { get; }
  
  public ref float SystemLoadScale { get; }
  
  public ref float InitialOffset { get; }
  
  public ref bool EnableLinearConstraint { get; }
  
  public ref bool EnableAngularConstraint { get; }
  
  public ref float MotorFrequency { get; }
  
  public ref float MotorDampingRatio { get; }
  
  public ref bool UseEntityPivot { get; }
  
  public IConstraintSoundInfo SoundInfo { get; }
}