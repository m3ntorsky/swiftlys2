using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysXJoint_t : ISchemaClass {

  
  public ref ushort Type { get; }
  
  public ref ushort Body1 { get; }
  
  public ref ushort Body2 { get; }
  
  public ref ushort Flags { get; }
  
  public ref CTransform Frame1 { get; }
  
  public ref CTransform Frame2 { get; }
  
  public ref bool EnableCollision { get; }
  
  public ref bool IsLinearConstraintDisabled { get; }
  
  public ref bool IsAngularConstraintDisabled { get; }
  
  public ref bool EnableLinearLimit { get; }
  
  public IVPhysXRange_t LinearLimit { get; }
  
  public ref bool EnableLinearMotor { get; }
  
  public ref Vector LinearTargetVelocity { get; }
  
  public ref float MaxForce { get; }
  
  public ref bool EnableSwingLimit { get; }
  
  public IVPhysXRange_t SwingLimit { get; }
  
  public ref bool EnableTwistLimit { get; }
  
  public IVPhysXRange_t TwistLimit { get; }
  
  public ref bool EnableAngularMotor { get; }
  
  public ref Vector AngularTargetVelocity { get; }
  
  public ref float MaxTorque { get; }
  
  public ref float LinearFrequency { get; }
  
  public ref float LinearDampingRatio { get; }
  
  public ref float AngularFrequency { get; }
  
  public ref float AngularDampingRatio { get; }
  
  public ref float Friction { get; }
  
  public ref float Elasticity { get; }
  
  public ref float ElasticDamping { get; }
  
  public ref float Plasticity { get; }
  
  public ref CUtlString Tag { get; }
}