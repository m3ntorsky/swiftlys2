using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventServerProcessNetworking_t : EventSimulate_t, IEventServerProcessNetworking_t {

  public EventServerProcessNetworking_t(nint handle) : base(handle) {
  }

  public EventServerProcessNetworking_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}