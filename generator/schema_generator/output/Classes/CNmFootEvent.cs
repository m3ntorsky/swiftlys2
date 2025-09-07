using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFootEvent : CNmEvent, INmFootEvent {

  public CNmFootEvent(nint handle) : base(handle) {
  }

  public CNmFootEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref NmFootPhase_t Phase {
    get => ref _Handle.AsRef<NmFootPhase_t>(Schema.GetOffset(0x1F9E5CE14846D318));
  }


}