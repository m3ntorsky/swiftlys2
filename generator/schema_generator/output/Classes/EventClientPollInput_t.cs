using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientPollInput_t : SchemaClass, IEventClientPollInput_t {

  public EventClientPollInput_t(nint handle) : base(handle) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x1E8649A0F928A2EC));
  }
  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1E8649A01168EC02));
  }


}