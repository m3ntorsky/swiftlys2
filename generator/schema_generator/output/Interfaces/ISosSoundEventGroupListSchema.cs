using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosSoundEventGroupListSchema : ISchemaClass {

  
// CUtlVector< CSosSoundEventGroupSchema >
  public ref CUtlVector GroupList { get; }
}