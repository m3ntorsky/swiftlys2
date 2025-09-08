using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_IntervalTimer__CursorState_t : SchemaClass, IPulseCell_IntervalTimer__CursorState_t {

  public CPulseCell_IntervalTimer__CursorState_t(nint handle) : base(handle) {
  }

  public IGameTime_t StartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x63BF122697B5FA8E));
  }
  public IGameTime_t EndTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x63BF12267AA8F56B));
  }
  public ref float WaitInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x63BF122677B6B563));
  }
  public ref float WaitIntervalHigh {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x63BF12267540534F));
  }
  public ref bool CompleteOnNextWake {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x63BF122684615952));
  }


}