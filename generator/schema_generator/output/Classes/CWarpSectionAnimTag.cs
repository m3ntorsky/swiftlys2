using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWarpSectionAnimTag : CWarpSectionAnimTagBase, IWarpSectionAnimTag {

  public CWarpSectionAnimTag(nint handle) : base(handle) {
  }

  public CWarpSectionAnimTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool WarpPosition {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4C7992E6A30D730C));
  }
  public ref bool WarpOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4C7992E6613873F3));
  }


}