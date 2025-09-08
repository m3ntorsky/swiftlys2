using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSimTimer : CSimpleSimTimer, ISimTimer {

  public CSimTimer(nint handle) : base(handle) {
  }

  public ref float Interval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB9B19F86320F7B8E));
  }


}