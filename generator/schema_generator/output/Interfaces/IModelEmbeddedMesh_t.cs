using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelEmbeddedMesh_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref int MeshIndex { get; }
  
  public ref int DataBlock { get; }
  
  public ref int MorphBlock { get; }
  
  public ref CUtlVector VertexBuffers { get; }
  
  public ref CUtlVector IndexBuffers { get; }
  
  public ref CUtlVector ToolsBuffers { get; }
  
  public ref int VBIBBlock { get; }
  
  public ref int ToolsVBBlock { get; }
  
}