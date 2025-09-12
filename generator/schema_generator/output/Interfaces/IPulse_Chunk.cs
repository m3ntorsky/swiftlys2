using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_Chunk : ISchemaClass {

  
  public ISchemaUntypedField Instructions { get; }
  
  public ISchemaUntypedField Registers { get; }
  
  public ISchemaUntypedField InstructionEditorIDs { get; }
}