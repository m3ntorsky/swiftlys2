using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMeshletDescriptor : ISchemaClass {

  
  public IPackedAABB_t PackedAABB { get; }
  
  public IDrawCullingData CullingData { get; }
  
  public ref uint VertexOffset { get; }
  
  public ref uint TriangleOffset { get; }
  
  public ref byte VertexCount { get; }
  
  public ref byte TriangleCount { get; }
}