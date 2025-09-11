using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseSelectorOutflowList_t : ISchemaClass {

  
// CUtlVector< OutflowWithRequirements_t >
  public ref CUtlVector Outflows { get; }
}