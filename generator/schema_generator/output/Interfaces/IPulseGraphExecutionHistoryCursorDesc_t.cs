using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphExecutionHistoryCursorDesc_t : ISchemaClass {

  public ref CUtlVector AncestorCursorIDs { get; }
  
  public IPulseDocNodeID_t SpawnNodeID { get; }
  
  public IPulseDocNodeID_t RetiredAtNodeID { get; }
  
  public ref float LastReferenced { get; }
  
  public ref int LastValidEntryIdx { get; }
  
}