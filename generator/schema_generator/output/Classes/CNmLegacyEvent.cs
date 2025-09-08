using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmLegacyEvent : CNmEvent, INmLegacyEvent {

  public CNmLegacyEvent(nint handle) : base(handle) {
  }

  public ref CUtlString AnimEventClassName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x78C36574C276DA33));
  }
  public ISchemaUntypedField KV {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x78C36574F70B8074));
  }


}