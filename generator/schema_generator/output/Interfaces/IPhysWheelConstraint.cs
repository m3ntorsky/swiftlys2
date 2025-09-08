using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysWheelConstraint : IPhysConstraint {

  public ref float SuspensionFrequency { get; }
  
  public ref float SuspensionDampingRatio { get; }
  
  public ref float SuspensionHeightOffset { get; }
  
  public ref bool EnableSuspensionLimit { get; }
  
  public ref float MinSuspensionOffset { get; }
  
  public ref float MaxSuspensionOffset { get; }
  
  public ref bool EnableSteeringLimit { get; }
  
  public ref float MinSteeringAngle { get; }
  
  public ref float MaxSteeringAngle { get; }
  
  public ref float SteeringAxisFriction { get; }
  
  public ref float SpinAxisFriction { get; }
  
  public CHandle<IBaseEntity> SteeringMimicsEntity { get; }
  
}