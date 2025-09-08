using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRangeFloat : ISchemaClass {

  public ISchemaFixedArray<float> Value { get; }
  
}