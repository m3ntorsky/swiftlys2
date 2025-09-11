using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWorldNode_t : ISchemaClass {

  
// CUtlVector< SceneObject_t >
  public ref CUtlVector SceneObjects { get; }
  
// CUtlVector< InfoOverlayData_t >
  public ref CUtlVector InfoOverlays { get; }
  
  public ref CUtlVector<ushort> VisClusterMembership { get; }
  
// CUtlVector< AggregateSceneObject_t >
  public ref CUtlVector AggregateSceneObjects { get; }
  
// CUtlVector< ClutterSceneObject_t >
  public ref CUtlVector ClutterSceneObjects { get; }
  
// CUtlVector< ExtraVertexStreamOverride_t >
  public ref CUtlVector ExtraVertexStreamOverrides { get; }
  
// CUtlVector< MaterialOverride_t >
  public ref CUtlVector MaterialOverrides { get; }
  
// CUtlVector< WorldNodeOnDiskBufferData_t >
  public ref CUtlVector ExtraVertexStreams { get; }
  
// CUtlVector< AggregateInstanceStreamOnDiskData_t >
  public ref CUtlVector AggregateInstanceStreams { get; }
  
// CUtlVector< AggregateVertexAlbedoStreamOnDiskData_t >
  public ref CUtlVector VertexAlbedoStreams { get; }
  
  public ref CUtlVector<CUtlString> LayerNames { get; }
  
  public ref CUtlVector<byte> SceneObjectLayerIndices { get; }
  
  public ref CUtlVector<byte> OverlayLayerIndices { get; }
  
  public ref CUtlString GrassFileName { get; }
  
  public IBakedLightingInfo_t NodeLightingInfo { get; }
  
  public ref bool HasBakedGeometryFlag { get; }
}