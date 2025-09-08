using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientAdvanceTick_t : EventAdvanceTick_t, IEventClientAdvanceTick_t {

  public EventClientAdvanceTick_t(nint handle) : base(handle) {
  }




}