using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventAdvanceTick_t : EventSimulate_t, IEventAdvanceTick_t {

  public EventAdvanceTick_t(nint handle) : base(handle) {
  }

  public EventAdvanceTick_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CurrentTick {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB79597D53C23687B));
  }
  public ref int CurrentTickThisFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB79597D509CE99F8));
  }
  public ref int TotalTicksThisFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB79597D524EA7826));
  }
  public ref int TotalTicks {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB79597D545397B31));
  }


}