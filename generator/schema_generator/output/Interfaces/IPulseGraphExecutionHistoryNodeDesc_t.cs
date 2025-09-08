using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphExecutionHistoryNodeDesc_t : ISchemaClass {

  public ref CBufferString StrCellDesc { get; }
  
  public ISchemaUntypedField StrBindingName { get; }
  
}