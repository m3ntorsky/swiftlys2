using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyGroupAnimTag : CAnimTagBase, IBodyGroupAnimTag {

  public CBodyGroupAnimTag(nint handle) : base(handle) {
  }

  public CBodyGroupAnimTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Priority {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4FBB343CE7EFB335));
  }
  public ref CUtlVector< CBodyGroupSetting > BodyGroupSettings {
    get => ref _Handle.AsRef<CUtlVector< CBodyGroupSetting >>(Schema.GetOffset(0x4FBB343C3BE7BAE1));
  }


}