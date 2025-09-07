using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmEntityAttributeIntEvent : CNmEntityAttributeEventBase, INmEntityAttributeIntEvent {

  public CNmEntityAttributeIntEvent(nint handle) : base(handle) {
  }

  public CNmEntityAttributeIntEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int IntValue {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22C4DC17BF67A7DB));
  }


}