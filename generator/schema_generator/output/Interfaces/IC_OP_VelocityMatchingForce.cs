using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_VelocityMatchingForce : IParticleFunctionOperator {

  
  public ref float DirScale { get; }
  
  public ref float SpdScale { get; }
  
  public ref float NeighborDistance { get; }
  
  public ref float FacingStrength { get; }
  
  public ref bool UseAABB { get; }
  
  public ref int CPBroadcast { get; }
}