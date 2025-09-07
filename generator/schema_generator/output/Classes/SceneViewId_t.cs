using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SceneViewId_t : SchemaClass, ISceneViewId_t {

  public SceneViewId_t(nint handle) : base(handle) {
  }

  public SceneViewId_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ulong ViewId {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0x66190338AE3CB1A1));
  }
  public ref ulong FrameCount {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0x661903381DBCD049));
  }


}