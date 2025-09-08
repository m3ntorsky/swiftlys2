using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPostProcessingLocalContrastParameters_t : ISchemaClass {

  public ref float LocalContrastStrength { get; }
  
  public ref float LocalContrastEdgeStrength { get; }
  
  public ref float LocalContrastVignetteStart { get; }
  
  public ref float LocalContrastVignetteEnd { get; }
  
  public ref float LocalContrastVignetteBlur { get; }
  
}