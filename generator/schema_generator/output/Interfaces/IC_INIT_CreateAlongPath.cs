using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateAlongPath : IParticleFunctionInitializer {

  
  public ref float MaxDistance { get; }
  
  public IPathParameters PathParams { get; }
  
  public ref bool UseRandomCPs { get; }
  
  public ref Vector EndOffset { get; }
  
  public ref bool SaveOffset { get; }
}