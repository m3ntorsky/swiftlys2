using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IChainToSolveData_t : ISchemaClass {

  public ref int ChainIndex { get; }
  
  public IIKSolverSettings_t SolverSettings { get; }
  
  public IIKTargetSettings_t TargetSettings { get; }
  
  public ref SolveIKChainAnimNodeDebugSetting DebugSetting { get; }
  
  public ref float DebugNormalizedValue { get; }
  
  public ref VectorAligned DebugOffset { get; }
  
}