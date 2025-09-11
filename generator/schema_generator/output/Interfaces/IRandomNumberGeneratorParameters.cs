using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRandomNumberGeneratorParameters : ISchemaClass {

  
  public ref bool DistributeEvenly { get; }
  
  public ref int Seed { get; }
}