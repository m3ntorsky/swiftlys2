using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphExecutionHistory : ISchemaClass {

  public IPulseGraphInstanceID_t InstanceID { get; }
  
  public ref CUtlString StrFileName { get; }
  
  public ref CUtlVector<PointerTo<PulseGraphExecutionHistoryEntry_t>> History { get; }
  
  public ISchemaUntypedField MapCellDesc { get; }
  
  public ISchemaUntypedField MapCursorDesc { get; }
  
}