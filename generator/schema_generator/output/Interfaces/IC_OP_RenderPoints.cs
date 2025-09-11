using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderPoints : IParticleFunctionRenderer {

  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
}