using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWorldNode_t : ISchemaClass {

  public ref CUtlVector SceneObjects { get; }
  
  public ref CUtlVector InfoOverlays { get; }
  
  public ref CUtlVector<ushort> VisClusterMembership { get; }
  
  public ref CUtlVector AggregateSceneObjects { get; }
  
  public ref CUtlVector ClutterSceneObjects { get; }
  
  public ref CUtlVector ExtraVertexStreamOverrides { get; }
  
  public ref CUtlVector MaterialOverrides { get; }
  
  public ref CUtlVector ExtraVertexStreams { get; }
  
  public ref CUtlVector AggregateInstanceStreams { get; }
  
  public ref CUtlVector VertexAlbedoStreams { get; }
  
  public ref CUtlVector<CUtlString> LayerNames { get; }
  
  public ref CUtlVector<byte> SceneObjectLayerIndices { get; }
  
  public ref CUtlVector<byte> OverlayLayerIndices { get; }
  
  public ref CUtlString GrassFileName { get; }
  
  public IBakedLightingInfo_t NodeLightingInfo { get; }
  
  public ref bool HasBakedGeometryFlag { get; }
  
}