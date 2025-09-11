using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnHull_t : ISchemaClass {

  
  public ref Vector Centroid { get; }
  
  public ref float MaxAngularRadius { get; }
  
  public IAABB_t Bounds { get; }
  
  public ref Vector OrthographicAreas { get; }
  
  public ref matrix3x4_t MassProperties { get; }
  
  public ref float Volume { get; }
  
  public ref float SurfaceArea { get; }
  
// CUtlVector< RnVertex_t >
  public ref CUtlVector Vertices { get; }
  
  public ref CUtlVector<Vector> VertexPositions { get; }
  
// CUtlVector< RnHalfEdge_t >
  public ref CUtlVector Edges { get; }
  
// CUtlVector< RnFace_t >
  public ref CUtlVector Faces { get; }
  
// CUtlVector< RnPlane_t >
  public ref CUtlVector FacePlanes { get; }
  
  public ref uint Flags { get; }
  
  public IRegionSVM RegionSVM { get; }
}