using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventServerSimulate_t : EventSimulate_t, IEventServerSimulate_t {

  public EventServerSimulate_t(nint handle) : base(handle) {
  }

  public EventServerSimulate_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}