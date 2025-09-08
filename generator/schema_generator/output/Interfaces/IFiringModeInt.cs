using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFiringModeInt : ISchemaClass {

  public ISchemaFixedArray<int> Values { get; }
  
}