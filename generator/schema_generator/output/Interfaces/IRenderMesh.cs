using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderMesh : ISchemaClass {

  public ref CUtlLeanVectorFixedGrowable<CSceneObjectData,1> SceneObjects { get; }
  
  public ref CUtlLeanVector<CBaseConstraint*> Constraints { get; }
  
  public IRenderSkeleton Skeleton { get; }
  
  public ref bool UseUV2ForCharting { get; }
  
  public ref bool EmbeddedMapMesh { get; }
  
  public IDynamicMeshDeformParams_t MeshDeformParams { get; }
  
  public IRenderGroom GroomData { get; }
  
}