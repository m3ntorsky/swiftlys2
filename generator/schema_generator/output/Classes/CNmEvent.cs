using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmEvent : SchemaClass, INmEvent {

  public CNmEvent(nint handle) : base(handle) {
  }

  public CNmEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float StartTimeSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF9871009C1FCF499));
  }
  public ref float DurationSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF9871009917797C0));
  }
  public ref CGlobalSymbol SyncID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xF987100915636837));
  }
  public ref bool ClientOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF9871009B39BA128));
  }


}