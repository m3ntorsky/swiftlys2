using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SnapshotRigidSkinToBones : IParticleFunctionOperator {

  public ref bool TransformNormals { get; }
  
  public ref bool TransformRadii { get; }
  
  public ref int ControlPointNumber { get; }
  
}