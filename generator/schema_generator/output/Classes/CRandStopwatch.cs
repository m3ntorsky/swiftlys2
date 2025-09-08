using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRandStopwatch : CStopwatchBase, IRandStopwatch {

  public CRandStopwatch(nint handle) : base(handle) {
  }

  public ref float MinInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x538C26044BB35EE4));
  }
  public ref float MaxInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x538C2604400B2156));
  }


}