using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientProcessInput_t : SchemaClass, IEventClientProcessInput_t {

  public EventClientProcessInput_t(nint handle) : base(handle) {
  }

  public EventClientProcessInput_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEngineLoopState_t LoopState {
    get => new EngineLoopState_t(_Handle + Schema.GetOffset(0x406EC290F928A2EC));
  }
  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x406EC2901168EC02));
  }
  public ref float TickInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x406EC290D279D07B));
  }
  public ref double TickStartTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x406EC29068A38BE7));
  }


}