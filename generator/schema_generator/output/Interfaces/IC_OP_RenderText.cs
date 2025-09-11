using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderText : IParticleFunctionRenderer {

  
  public ref Color OutlineColor { get; }
  
  public ref CUtlString DefaultText { get; }
}