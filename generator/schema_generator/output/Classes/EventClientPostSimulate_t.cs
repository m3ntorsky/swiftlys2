using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientPostSimulate_t : EventSimulate_t, IEventClientPostSimulate_t {

  public EventClientPostSimulate_t(nint handle) : base(handle) {
  }

  public EventClientPostSimulate_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}