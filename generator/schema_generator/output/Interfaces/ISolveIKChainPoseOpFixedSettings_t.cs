using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISolveIKChainPoseOpFixedSettings_t : ISchemaClass {

  
// CUtlVector< ChainToSolveData_t >
  public ref CUtlVector ChainsToSolveData { get; }
}