using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPostProcessingVignetteParameters_t : ISchemaClass {

  
  public ref float VignetteStrength { get; }
  
  public ref Vector2D Center { get; }
  
  public ref float Radius { get; }
  
  public ref float Roundness { get; }
  
  public ref float Feather { get; }
  
  public ref Vector ColorTint { get; }
}