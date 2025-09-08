using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientPreOutput_t : SchemaClass, IEventClientPreOutput_t {

  public EventClientPreOutput_t(nint handle) : base(handle) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0xB79CB11BF928A2EC));
  }
  public ref double RenderTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0xB79CB11B3C2AE65A));
  }
  public ref double RenderFrameTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0xB79CB11BF2FB2D81));
  }
  public ref double RenderFrameTimeUnbounded {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0xB79CB11B735692FF));
  }
  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB79CB11B1168EC02));
  }
  public ref bool RenderOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB79CB11BE274559F));
  }


}