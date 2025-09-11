using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFiringModeFloat : ISchemaClass {

  
  public ISchemaFixedArray<float> Values { get; }
}