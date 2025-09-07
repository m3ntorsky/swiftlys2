using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventSimulate_t : SchemaClass, IEventSimulate_t {

  public EventSimulate_t(nint handle) : base(handle) {
  }

  public EventSimulate_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x39B7BD6EF928A2EC));
  }
  public ref bool FirstTick {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x39B7BD6EC8198F38));
  }
  public ref bool LastTick {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x39B7BD6E1704CC30));
  }


}