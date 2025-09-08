using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_InvokeBinding : ISchemaClass {

  public IPulseRegisterMap_t RegisterMap { get; }
  
  public ISchemaUntypedField FuncName { get; }
  
  public IPulseRuntimeCellIndex_t CellIndex { get; }
  
  public IPulseRuntimeChunkIndex_t SrcChunk { get; }
  
  public ref int SrcInstruction { get; }
  
}