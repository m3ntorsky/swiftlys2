using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRuleEntity : IBaseModelEntity {

  
  public ref CUtlSymbolLarge Master { get; }
}