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
  
  public ref CUtlVector Vertices { get; }
  
  public ref CUtlVector<Vector> VertexPositions { get; }
  
  public ref CUtlVector Edges { get; }
  
  public ref CUtlVector Faces { get; }
  
  public ref CUtlVector FacePlanes { get; }
  
  public ref uint Flags { get; }
  
  public IRegionSVM RegionSVM { get; }
  
}