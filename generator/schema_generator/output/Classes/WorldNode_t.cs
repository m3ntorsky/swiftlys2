using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class WorldNode_t : SchemaClass, IWorldNode_t {

  public WorldNode_t(nint handle) : base(handle) {
  }

  public WorldNode_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< SceneObject_t > SceneObjects {
    get => ref _Handle.AsRef<CUtlVector< SceneObject_t >>(Schema.GetOffset(0xFC310480332235A1));
  }
  public ref CUtlVector< InfoOverlayData_t > InfoOverlays {
    get => ref _Handle.AsRef<CUtlVector< InfoOverlayData_t >>(Schema.GetOffset(0xFC310480A7491B10));
  }
  public ref CUtlVector< uint16 > VisClusterMembership {
    get => ref _Handle.AsRef<CUtlVector< uint16 >>(Schema.GetOffset(0xFC310480F2C828CD));
  }
  public ref CUtlVector< AggregateSceneObject_t > AggregateSceneObjects {
    get => ref _Handle.AsRef<CUtlVector< AggregateSceneObject_t >>(Schema.GetOffset(0xFC31048072C832FC));
  }
  public ref CUtlVector< ClutterSceneObject_t > ClutterSceneObjects {
    get => ref _Handle.AsRef<CUtlVector< ClutterSceneObject_t >>(Schema.GetOffset(0xFC310480CB15C9CA));
  }
  public ref CUtlVector< ExtraVertexStreamOverride_t > ExtraVertexStreamOverrides {
    get => ref _Handle.AsRef<CUtlVector< ExtraVertexStreamOverride_t >>(Schema.GetOffset(0xFC310480E2732A38));
  }
  public ref CUtlVector< MaterialOverride_t > MaterialOverrides {
    get => ref _Handle.AsRef<CUtlVector< MaterialOverride_t >>(Schema.GetOffset(0xFC3104809D810D99));
  }
  public ref CUtlVector< WorldNodeOnDiskBufferData_t > ExtraVertexStreams {
    get => ref _Handle.AsRef<CUtlVector< WorldNodeOnDiskBufferData_t >>(Schema.GetOffset(0xFC310480544F1AA0));
  }
  public ref CUtlVector< AggregateInstanceStreamOnDiskData_t > AggregateInstanceStreams {
    get => ref _Handle.AsRef<CUtlVector< AggregateInstanceStreamOnDiskData_t >>(Schema.GetOffset(0xFC31048038CAE4B8));
  }
  public ref CUtlVector< AggregateVertexAlbedoStreamOnDiskData_t > VertexAlbedoStreams {
    get => ref _Handle.AsRef<CUtlVector< AggregateVertexAlbedoStreamOnDiskData_t >>(Schema.GetOffset(0xFC3104803DD793DB));
  }
  public ref CUtlVector< CUtlString > LayerNames {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xFC3104806E877012));
  }
  public ref CUtlVector< uint8 > SceneObjectLayerIndices {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0xFC310480F769C8CA));
  }
  public ref CUtlVector< uint8 > OverlayLayerIndices {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0xFC31048006D1D7C9));
  }
  public ref CUtlString GrassFileName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xFC310480FDDFCFE0));
  }
  public IBakedLightingInfo_t NodeLightingInfo {
    get => new BakedLightingInfo_t(_Handle + Schema.GetOffset(0xFC3104800E25D839));
  }
  public ref bool HasBakedGeometryFlag {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFC310480943F4594));
  }


}