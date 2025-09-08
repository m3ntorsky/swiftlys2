using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseSelectorOutflowList_t : ISchemaClass {

  public ref CUtlVector Outflows { get; }
  
}