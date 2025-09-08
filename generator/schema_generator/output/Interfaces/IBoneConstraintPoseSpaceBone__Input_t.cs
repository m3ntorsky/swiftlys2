using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneConstraintPoseSpaceBone__Input_t : ISchemaClass {

  public ref Vector InputValue { get; }
  
  public ref CUtlVector<CTransform> OutputTransformList { get; }
  
}