using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_Cull : IParticleFunctionOperator {

  public ref float CullPerc { get; }
  
  public ref float CullStart { get; }
  
  public ref float CullEnd { get; }
  
  public ref float CullExp { get; }
  
}