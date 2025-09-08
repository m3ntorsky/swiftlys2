using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RemapParticleCountToNamedModelElementScalar : IC_INIT_RemapParticleCountToScalar {

  public ref CStrongHandle<InfoForResourceTypeCModel> Model { get; }
  
  public ref CUtlString OutputMinName { get; }
  
  public ref CUtlString OutputMaxName { get; }
  
  public ref bool ModelFromRenderer { get; }
  
}