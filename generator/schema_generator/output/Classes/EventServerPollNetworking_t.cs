using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventServerPollNetworking_t : EventSimulate_t, IEventServerPollNetworking_t {

  public EventServerPollNetworking_t(nint handle) : base(handle) {
  }

  public EventServerPollNetworking_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}