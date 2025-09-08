using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateFromPlaneCache : IParticleFunctionInitializer {

  public ref Vector OffsetMin { get; }
  
  public ref Vector OffsetMax { get; }
  
  public ref bool UseNormal { get; }
  
}