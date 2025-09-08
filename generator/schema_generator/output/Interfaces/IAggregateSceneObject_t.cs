using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAggregateSceneObject_t : ISchemaClass {

  public ref ObjectTypeFlags_t AllFlags { get; }
  
  public ref ObjectTypeFlags_t AnyFlags { get; }
  
  public ref short Layer { get; }
  
  public ref short InstanceStream { get; }
  
  public ref short VertexAlbedoStream { get; }
  
  public ref CUtlVector AggregateMeshes { get; }
  
  public ref CUtlVector LodSetups { get; }
  
  public ref CUtlVector<ushort> VisClusterMembership { get; }
  
  public ref CUtlVector<matrix3x4_t> FragmentTransforms { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCModel> RenderableModel { get; }
  
}