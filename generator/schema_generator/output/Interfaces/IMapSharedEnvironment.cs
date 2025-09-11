using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMapSharedEnvironment : ILogicalEntity {

  
  public ref CUtlSymbolLarge TargetMapName { get; }
}