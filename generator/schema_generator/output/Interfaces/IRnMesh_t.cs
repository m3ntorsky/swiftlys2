using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnMesh_t : ISchemaClass {

  public ref Vector Min { get; }
  
  public ref Vector Max { get; }
  
  public ref CUtlVector Nodes { get; }
  
  public ISchemaUntypedField Vertices { get; }
  
  public ref CUtlVector Triangles { get; }
  
  public ref CUtlVector Wings { get; }
  
  public ref CUtlVector<byte> TriangleEdgeFlags { get; }
  
  public ref CUtlVector<byte> Materials { get; }
  
  public ref Vector OrthographicAreas { get; }
  
  public ref uint Flags { get; }
  
  public ref uint DebugFlags { get; }
  
}