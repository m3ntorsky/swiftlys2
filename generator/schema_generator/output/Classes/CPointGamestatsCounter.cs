using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointGamestatsCounter : CPointEntity, IPointGamestatsCounter {

  public CPointGamestatsCounter(nint handle) : base(handle) {
  }

  public CPointGamestatsCounter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge StrStatisticName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xDB27C27354212AB1));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDB27C2733A7C5965));
  }


}