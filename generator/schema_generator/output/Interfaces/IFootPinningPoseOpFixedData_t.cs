using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootPinningPoseOpFixedData_t : ISchemaClass {

  
// CUtlVector< FootFixedData_t >
  public ref CUtlVector FootInfo { get; }
  
  public ref float BlendTime { get; }
  
  public ref float LockBreakDistance { get; }
  
  public ref float MaxLegTwist { get; }
  
  public ref int HipBoneIndex { get; }
  
  public ref bool ApplyLegTwistLimits { get; }
  
  public ref bool ApplyFootRotationLimits { get; }
}