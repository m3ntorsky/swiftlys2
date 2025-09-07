using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventAppShutdown_t : SchemaClass, IEventAppShutdown_t {

  public EventAppShutdown_t(nint handle) : base(handle) {
  }

  public EventAppShutdown_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Dummy0 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x815B1527A26B2B9D));
  }


}