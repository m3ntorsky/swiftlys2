using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientPostOutput_t : SchemaClass, IEventClientPostOutput_t {

  public EventClientPostOutput_t(nint handle) : base(handle) {
  }

  public EventClientPostOutput_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x98578A18F928A2EC));
  }
  public ref double RenderTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x98578A183C2AE65A));
  }
  public ref float RenderFrameTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x98578A18F2FB2D81));
  }
  public ref float RenderFrameTimeUnbounded {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x98578A18735692FF));
  }
  public ref bool RenderOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x98578A18E274559F));
  }


}