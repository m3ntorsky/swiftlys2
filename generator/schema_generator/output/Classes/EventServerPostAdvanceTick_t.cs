using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventServerPostAdvanceTick_t : EventPostAdvanceTick_t, IEventServerPostAdvanceTick_t {

  public EventServerPostAdvanceTick_t(nint handle) : base(handle) {
  }

  public EventServerPostAdvanceTick_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}