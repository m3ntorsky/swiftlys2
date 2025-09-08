using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_CallInfo : ISchemaClass {

  public ISchemaUntypedField PortName { get; }
  
  public IPulseDocNodeID_t EditorNodeID { get; }
  
  public IPulseRegisterMap_t RegisterMap { get; }
  
  public IPulseDocNodeID_t CallMethodID { get; }
  
  public IPulseRuntimeChunkIndex_t SrcChunk { get; }
  
  public ref int SrcInstruction { get; }
  
}