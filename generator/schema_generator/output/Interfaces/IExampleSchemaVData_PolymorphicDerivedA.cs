using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IExampleSchemaVData_PolymorphicDerivedA : IExampleSchemaVData_PolymorphicBase {

  public ref int DerivedA { get; }
  
}