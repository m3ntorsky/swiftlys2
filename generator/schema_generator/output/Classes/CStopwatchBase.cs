using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStopwatchBase : CSimpleSimTimer, IStopwatchBase {

  public CStopwatchBase(nint handle) : base(handle) {
  }

  public CStopwatchBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool IsRunning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x80DA66DCF34F2570));
  }


}