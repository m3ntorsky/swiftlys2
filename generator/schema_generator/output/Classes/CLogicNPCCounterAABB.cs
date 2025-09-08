using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicNPCCounterAABB : CLogicNPCCounter, ILogicNPCCounterAABB {

  public CLogicNPCCounterAABB(nint handle) : base(handle) {
  }

  public ref Vector DistanceOuterMins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x264C2C4B185EC6F4));
  }
  public ref Vector DistanceOuterMaxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x264C2C4B99738B36));
  }
  public ref Vector OuterMins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x264C2C4B30928F3D));
  }
  public ref Vector OuterMaxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x264C2C4BC9A77947));
  }


}