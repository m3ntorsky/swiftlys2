using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientFrameSimulate_t : SchemaClass, IEventClientFrameSimulate_t {

  public EventClientFrameSimulate_t(nint handle) : base(handle) {
  }

  public EventClientFrameSimulate_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x18229C4F928A2EC));
  }
  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x18229C41168EC02));
  }
  public ref float FrameTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x18229C4659DF875));
  }
  public ref bool ScheduleSendTickPacket {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x18229C400A650C3));
  }


}