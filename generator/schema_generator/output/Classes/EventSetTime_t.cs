using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventSetTime_t : SchemaClass, IEventSetTime_t {

  public EventSetTime_t(nint handle) : base(handle) {
  }

  public EventSetTime_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x260F6EEFF928A2EC));
  }
  public ref int ClientOutputFrames {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x260F6EEF19578919));
  }
  public ref double RealTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x260F6EEF1168EC02));
  }
  public ref double RenderTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x260F6EEF3C2AE65A));
  }
  public ref double RenderFrameTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x260F6EEFF2FB2D81));
  }
  public ref double RenderFrameTimeUnbounded {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x260F6EEF735692FF));
  }
  public ref double RenderFrameTimeUnscaled {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x260F6EEFCCC75750));
  }
  public ref double TickRemainder {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x260F6EEF330ED365));
  }


}