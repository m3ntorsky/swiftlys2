using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRangeInt : ISchemaClass {

  public ISchemaFixedArray<int> Value { get; }
  
}