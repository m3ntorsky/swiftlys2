using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeVertexMapBuild_t : ISchemaClass {

  
  public ref CUtlString VertexMapName { get; }
  
  public ref uint NameHash { get; }
  
  public ref Color Color { get; }
  
  public ref float VolumetricSolveStrength { get; }
  
  public ref int ScaleSourceNode { get; }
  
  public ref CUtlVector<float> Weights { get; }
}