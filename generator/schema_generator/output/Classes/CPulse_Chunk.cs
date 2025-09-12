using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_Chunk : SchemaClass, IPulse_Chunk {

  public CPulse_Chunk(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Instructions {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x816932094D358BC4));
  }
  public ISchemaUntypedField Registers {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x81693209BB828A49));
  }
  public ISchemaUntypedField InstructionEditorIDs {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x81693209236D8B64));
  }


}