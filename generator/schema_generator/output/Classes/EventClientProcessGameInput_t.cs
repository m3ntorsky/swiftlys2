using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientProcessGameInput_t : SchemaClass, IEventClientProcessGameInput_t {

  public EventClientProcessGameInput_t(nint handle) : base(handle) {
  }

  public EventClientProcessGameInput_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x705D7E06F928A2EC));
  }
  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x705D7E061168EC02));
  }
  public ref float FrameTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x705D7E06659DF875));
  }


}