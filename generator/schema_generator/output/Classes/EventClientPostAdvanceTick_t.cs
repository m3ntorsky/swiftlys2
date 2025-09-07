using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientPostAdvanceTick_t : EventPostAdvanceTick_t, IEventClientPostAdvanceTick_t {

  public EventClientPostAdvanceTick_t(nint handle) : base(handle) {
  }

  public EventClientPostAdvanceTick_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}