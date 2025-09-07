using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmGraphDefinition__ExternalGraphSlot_t : SchemaClass, INmGraphDefinition__ExternalGraphSlot_t {

  public CNmGraphDefinition__ExternalGraphSlot_t(nint handle) : base(handle) {
  }

  public CNmGraphDefinition__ExternalGraphSlot_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short NodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xFF128092124AB5CC));
  }
  public ref CGlobalSymbol SlotID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xFF128092EA2BB724));
  }


}