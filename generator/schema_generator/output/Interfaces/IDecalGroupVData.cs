using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDecalGroupVData : ISchemaClass {

  public ref CUtlVector Options { get; }
  
  public ref float TotalProbability { get; }
  
}