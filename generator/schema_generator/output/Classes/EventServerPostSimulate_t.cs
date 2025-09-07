using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventServerPostSimulate_t : EventSimulate_t, IEventServerPostSimulate_t {

  public EventServerPostSimulate_t(nint handle) : base(handle) {
  }

  public EventServerPostSimulate_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}