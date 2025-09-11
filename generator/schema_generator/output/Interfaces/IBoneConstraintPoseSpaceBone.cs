using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneConstraintPoseSpaceBone : IBaseConstraint {

  
// CUtlVector< CBoneConstraintPoseSpaceBone::Input_t >
  public ref CUtlVector InputList { get; }
}