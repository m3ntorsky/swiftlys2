using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDEvent : CNmEvent, INmIDEvent {

  public CNmIDEvent(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x31E463E295066900));
  }
  public ref CGlobalSymbol SecondaryID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x31E463E29B39DB84));
  }


}