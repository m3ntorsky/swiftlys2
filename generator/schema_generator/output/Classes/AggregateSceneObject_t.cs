using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AggregateSceneObject_t : SchemaClass, IAggregateSceneObject_t {

  public AggregateSceneObject_t(nint handle) : base(handle) {
  }

  public ref ObjectTypeFlags_t AllFlags {
    get => ref _Handle.AsRef<ObjectTypeFlags_t>(Schema.GetOffset(0xEF81F2D4DD9F35F7));
  }
  public ref ObjectTypeFlags_t AnyFlags {
    get => ref _Handle.AsRef<ObjectTypeFlags_t>(Schema.GetOffset(0xEF81F2D456CC84B4));
  }
  public ref short Layer {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xEF81F2D4477C7B2A));
  }
  public ref short InstanceStream {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xEF81F2D4B5A8384A));
  }
  public ref short VertexAlbedoStream {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xEF81F2D42540B1EA));
  }
  public ref CUtlVector AggregateMeshes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xEF81F2D402570BA1));
  }
  public ref CUtlVector LodSetups {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xEF81F2D4B0CE61E2));
  }
  public ref CUtlVector<ushort> VisClusterMembership {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0xEF81F2D4F2C828CD));
  }
  public ref CUtlVector<matrix3x4_t> FragmentTransforms {
    get => ref _Handle.AsRef<CUtlVector<matrix3x4_t>>(Schema.GetOffset(0xEF81F2D4192EBA20));
  }
  public ref CStrongHandle<InfoForResourceTypeCModel> RenderableModel {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCModel>>(Schema.GetOffset(0xEF81F2D42AEEFA82));
  }


}