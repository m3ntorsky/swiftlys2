using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ExtraVertexStreamOverride_t : BaseSceneObjectOverride_t, IExtraVertexStreamOverride_t {

  public ExtraVertexStreamOverride_t(nint handle) : base(handle) {
  }

  public ExtraVertexStreamOverride_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint SubSceneObject {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x38857FE855C3CCBC));
  }
  public ref uint DrawCallIndex {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x38857FE8FA5614D5));
  }
  public ref MeshDrawPrimitiveFlags_t AdditionalMeshDrawPrimitiveFlags {
    get => ref _Handle.AsRef<MeshDrawPrimitiveFlags_t>(Schema.GetOffset(0x38857FE8F0E57F2B));
  }
  public IRenderBufferBinding ExtraBufferBinding {
    get => new CRenderBufferBinding(_Handle + Schema.GetOffset(0x38857FE800630FD0));
  }


}