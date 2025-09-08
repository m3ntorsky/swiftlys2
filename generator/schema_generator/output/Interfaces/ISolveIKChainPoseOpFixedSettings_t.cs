using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISolveIKChainPoseOpFixedSettings_t : ISchemaClass {

  public ref CUtlVector ChainsToSolveData { get; }
  
}