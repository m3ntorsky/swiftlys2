using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphExecutionHistoryEntry_t : ISchemaClass {

  public IPulseCursorID_t CursorID { get; }
  
  public IPulseDocNodeID_t EditorID { get; }
  
  public ref float ExecTime { get; }
  
  public ref uint Flags { get; }
  
  public ISchemaUntypedField TagName { get; }
  
}