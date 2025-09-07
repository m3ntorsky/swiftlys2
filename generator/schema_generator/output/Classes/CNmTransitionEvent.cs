using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTransitionEvent : CNmEvent, INmTransitionEvent {

  public CNmTransitionEvent(nint handle) : base(handle) {
  }

  public CNmTransitionEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref NmTransitionRule_t Rule {
    get => ref _Handle.AsRef<NmTransitionRule_t>(Schema.GetOffset(0x11493D8CBA097173));
  }
  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x11493D8C95066900));
  }


}