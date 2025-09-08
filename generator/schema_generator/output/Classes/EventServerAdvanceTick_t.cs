using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventServerAdvanceTick_t : EventAdvanceTick_t, IEventServerAdvanceTick_t {

  public EventServerAdvanceTick_t(nint handle) : base(handle) {
  }




}