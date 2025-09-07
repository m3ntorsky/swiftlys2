using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameSceneNodeHandle : SchemaClass, IGameSceneNodeHandle {

  public CGameSceneNodeHandle(nint handle) : base(handle) {
  }

  public CGameSceneNodeHandle(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CEntityHandle Owner {
    get => ref _Handle.AsRef<CEntityHandle>(Schema.GetOffset(0x9A961FAF6D89572));
  }
  public ref CUtlStringToken Name {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x9A961FA4D8F5786));
  }

  public void OwnerUpdated() {
    Schema.Update(_Handle, 0x9A961FAF6D89572);
  }
  public void NameUpdated() {
    Schema.Update(_Handle, 0x9A961FA4D8F5786);
  }
}