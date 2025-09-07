using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_ItemServices : CPlayer_ItemServices, ICSPlayer_ItemServices {

  public CCSPlayer_ItemServices(nint handle) : base(handle) {
  }

  public CCSPlayer_ItemServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool HasDefuser {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6BB85EAD5AF87AF5));
  }
  public ref bool HasHelmet {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6BB85EAD4240B6F6));
  }

  public void HasDefuserUpdated() {
    Schema.Update(_Handle, 0x6BB85EAD5AF87AF5);
  }
  public void HasHelmetUpdated() {
    Schema.Update(_Handle, 0x6BB85EAD4240B6F6);
  }
}