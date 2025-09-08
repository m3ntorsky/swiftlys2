using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_OutflowConnection : ISchemaClass {

  public ISchemaUntypedField SourceOutflowName { get; }
  
  public IPulseRuntimeChunkIndex_t DestChunk { get; }
  
  public ref int Instruction { get; }
  
  public IPulseRegisterMap_t OutflowRegisterMap { get; }
  
}