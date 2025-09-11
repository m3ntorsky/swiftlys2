using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPostProcessingFogScatteringParameters_t : ISchemaClass {

  
  public ref float Radius { get; }
  
  public ref float Scale { get; }
  
  public ref float CubemapScale { get; }
  
  public ref float VolumetricScale { get; }
  
  public ref float GradientScale { get; }
}