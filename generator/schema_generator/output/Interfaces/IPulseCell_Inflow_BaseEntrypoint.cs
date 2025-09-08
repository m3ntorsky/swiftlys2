using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Inflow_BaseEntrypoint : IPulseCell_BaseFlow {

  public IPulseRuntimeChunkIndex_t EntryChunk { get; }
  
  public IPulseRegisterMap_t RegisterMap { get; }
  
}