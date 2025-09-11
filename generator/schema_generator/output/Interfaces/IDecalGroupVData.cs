using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDecalGroupVData : ISchemaClass {

  
// CUtlVector< DecalGroupOption_t >
  public ref CUtlVector Options { get; }
  
  public ref float TotalProbability { get; }
}