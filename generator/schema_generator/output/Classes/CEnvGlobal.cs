using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvGlobal : CLogicalEntity, IEnvGlobal {

  public CEnvGlobal(nint handle) : base(handle) {
  }

  public ISchemaUntypedField OutCounter {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC5E41E3E69415251));
  }
  public ISchemaUntypedField Globalstate {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC5E41E3E77A86653));
  }
  public ref int Triggermode {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC5E41E3E845DF22C));
  }
  public ref int Initialstate {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC5E41E3E1E997294));
  }
  public ref int Counter {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC5E41E3EA311A543));
  }


}