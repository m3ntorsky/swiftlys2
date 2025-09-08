using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventPreDataUpdate_t : SchemaClass, IEventPreDataUpdate_t {

  public EventPreDataUpdate_t(nint handle) : base(handle) {
  }

  public ref int Count {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xEDF6C5BA7D31AC08));
  }


}