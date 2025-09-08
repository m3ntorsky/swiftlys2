using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_Chunk : ISchemaClass {

  public ref CUtlLeanVector<PGDInstruction_t> Instructions { get; }
  
  public ref CUtlLeanVector<CPulse_RegisterInfo> Registers { get; }
  
  public ref CUtlLeanVector<PulseDocNodeID_t> InstructionEditorIDs { get; }
  
}