using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStopwatch : CStopwatchBase, IStopwatch {

  public CStopwatch(nint handle) : base(handle) {
  }

  public CStopwatch(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Interval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40B847F1320F7B8E));
  }


}