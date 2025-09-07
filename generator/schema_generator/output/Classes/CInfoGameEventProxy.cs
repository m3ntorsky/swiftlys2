using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoGameEventProxy : CPointEntity, IInfoGameEventProxy {

  public CInfoGameEventProxy(nint handle) : base(handle) {
  }

  public CInfoGameEventProxy(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge EventName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x483B3FC078114A54));
  }
  public ref float Range {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x483B3FC03FC92844));
  }


}