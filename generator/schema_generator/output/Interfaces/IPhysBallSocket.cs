using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysBallSocket : IPhysConstraint {

  public ref float JointFriction { get; }
  
  public ref bool EnableSwingLimit { get; }
  
  public ref float SwingLimit { get; }
  
  public ref bool EnableTwistLimit { get; }
  
  public ref float MinTwistAngle { get; }
  
  public ref float MaxTwistAngle { get; }
  
}