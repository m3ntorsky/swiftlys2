using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventPostDataUpdate_t : SchemaClass, IEventPostDataUpdate_t {

  public EventPostDataUpdate_t(nint handle) : base(handle) {
  }

  public EventPostDataUpdate_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Count {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x109BBB5B7D31AC08));
  }


}