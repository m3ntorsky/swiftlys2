using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDop26_t : ISchemaClass {

  public ISchemaFixedArray<float> Support { get; }
  
}