using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityKeyValueData_t : ISchemaClass {

  
// CUtlVector< EntityIOConnectionData_t >
  public ref CUtlVector Connections { get; }
  
  public ref CUtlBinaryBlock KeyValuesData { get; }
}