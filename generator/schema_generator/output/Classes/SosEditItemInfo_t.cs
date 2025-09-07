using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SosEditItemInfo_t : SchemaClass, ISosEditItemInfo_t {

  public SosEditItemInfo_t(nint handle) : base(handle) {
  }

  public SosEditItemInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref SosEditItemType_t ItemType {
    get => ref _Handle.AsRef<SosEditItemType_t>(Schema.GetOffset(0x8E29E1C0C91C9136));
  }
  public ref CUtlString ItemName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x8E29E1C0575A2B25));
  }
  public ref CUtlString ItemTypeName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x8E29E1C0B2F8CB75));
  }
  public ref CUtlString ItemKVString {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x8E29E1C0A0151DD6));
  }
  public ref Vector2D ItemPos {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x8E29E1C0AB2D0B6C));
  }


}