using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISelectedEditItemInfo_t : ISchemaClass {

  
// CUtlVector< SosEditItemInfo_t >
  public ref CUtlVector EditItems { get; }
}