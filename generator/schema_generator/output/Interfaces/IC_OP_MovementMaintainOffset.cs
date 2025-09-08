using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MovementMaintainOffset : IParticleFunctionOperator {

  public ref Vector Offset { get; }
  
  public ref int CP { get; }
  
  public ref bool RadiusScale { get; }
  
}