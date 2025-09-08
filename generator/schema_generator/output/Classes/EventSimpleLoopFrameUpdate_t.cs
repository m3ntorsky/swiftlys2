using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventSimpleLoopFrameUpdate_t : SchemaClass, IEventSimpleLoopFrameUpdate_t {

  public EventSimpleLoopFrameUpdate_t(nint handle) : base(handle) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x2C7358DAF928A2EC));
  }
  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2C7358DA1168EC02));
  }
  public ref float FrameTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2C7358DA659DF875));
  }


}