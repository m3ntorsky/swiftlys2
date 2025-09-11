using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISolveIKChainUpdateNode : IUnaryUpdateNode {

  
// CUtlVector< CSolveIKTargetHandle_t >
  public ref CUtlVector TargetHandles { get; }
  
  public ISolveIKChainPoseOpFixedSettings_t OpFixedData { get; }
}