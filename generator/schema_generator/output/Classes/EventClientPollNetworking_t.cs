using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientPollNetworking_t : SchemaClass, IEventClientPollNetworking_t {

  public EventClientPollNetworking_t(nint handle) : base(handle) {
  }

  public EventClientPollNetworking_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int TickCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE9C02F00E25E6B27));
  }


}