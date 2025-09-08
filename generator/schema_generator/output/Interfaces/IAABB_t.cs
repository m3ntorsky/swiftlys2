using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAABB_t : ISchemaClass {

  public ref Vector MinBounds { get; }
  
  public ref Vector MaxBounds { get; }
  
}