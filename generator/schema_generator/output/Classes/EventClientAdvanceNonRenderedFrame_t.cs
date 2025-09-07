using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientAdvanceNonRenderedFrame_t : SchemaClass, IEventClientAdvanceNonRenderedFrame_t {

  public EventClientAdvanceNonRenderedFrame_t(nint handle) : base(handle) {
  }

  public EventClientAdvanceNonRenderedFrame_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}