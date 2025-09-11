using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRemapFloat : ISchemaClass {

  
  public ISchemaFixedArray<float> Value { get; }
}