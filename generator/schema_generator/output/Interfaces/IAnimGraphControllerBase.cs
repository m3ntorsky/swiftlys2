using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimGraphControllerBase : ISchemaClass {

  public ref CUtlVectorFixedGrowable<CGlobalSymbol> ParamsToResetInPostGraphUpdate { get; }
  
}