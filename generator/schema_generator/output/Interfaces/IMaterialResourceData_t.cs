using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialResourceData_t : ISchemaClass {

  public ref CUtlString MaterialName { get; }
  
  public ref CUtlString ShaderName { get; }
  
  public ref CUtlVector IntParams { get; }
  
  public ref CUtlVector FloatParams { get; }
  
  public ref CUtlVector VectorParams { get; }
  
  public ref CUtlVector TextureParams { get; }
  
  public ref CUtlVector DynamicParams { get; }
  
  public ref CUtlVector DynamicTextureParams { get; }
  
  public ref CUtlVector IntAttributes { get; }
  
  public ref CUtlVector FloatAttributes { get; }
  
  public ref CUtlVector VectorAttributes { get; }
  
  public ref CUtlVector TextureAttributes { get; }
  
  public ref CUtlVector StringAttributes { get; }
  
  public ref CUtlVector<CUtlString> RenderAttributesUsed { get; }
  
}