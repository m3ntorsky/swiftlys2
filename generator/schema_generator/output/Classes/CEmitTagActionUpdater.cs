using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEmitTagActionUpdater : CAnimActionUpdater, IEmitTagActionUpdater {

  public CEmitTagActionUpdater(nint handle) : base(handle) {
  }

  public ref int TagIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x13C6F616C2026AAD));
  }
  public ref bool IsZeroDuration {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x13C6F61604008747));
  }


}