using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDynamicMeshDeformParams_t : ISchemaClass {

  
  public ref float TensionCompressScale { get; }
  
  public ref float TensionStretchScale { get; }
  
  public ref bool RecomputeSmoothNormalsAfterAnimation { get; }
  
  public ref bool ComputeDynamicMeshTensionAfterAnimation { get; }
  
  public ref bool SmoothNormalsAcrossUvSeams { get; }
}