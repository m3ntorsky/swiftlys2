using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SDFLighting : IParticleFunctionOperator {

  
  public ref Vector LightingDir { get; }
  
  public ref Vector Tint_0 { get; }
  
  public ref Vector Tint_1 { get; }
}