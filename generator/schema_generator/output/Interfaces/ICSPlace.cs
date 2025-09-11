using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlace : IServerOnlyModelEntity {

  
  public ref CUtlSymbolLarge Name { get; }
}