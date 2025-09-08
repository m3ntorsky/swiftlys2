using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientOutput_t : SchemaClass, IEventClientOutput_t {

  public EventClientOutput_t(nint handle) : base(handle) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0xDC610E16F928A2EC));
  }
  public ref float RenderTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDC610E163C2AE65A));
  }
  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDC610E161168EC02));
  }
  public ref float RenderFrameTimeUnbounded {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDC610E16735692FF));
  }
  public ref bool RenderOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDC610E16E274559F));
  }


}