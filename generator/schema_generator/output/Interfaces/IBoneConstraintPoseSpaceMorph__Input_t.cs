using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneConstraintPoseSpaceMorph__Input_t : ISchemaClass {

  public ref Vector InputValue { get; }
  
  public ref CUtlVector<float> OutputWeightList { get; }
  
}