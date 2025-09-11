using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IResponseContext_t : ISchemaClass {

  
  public ref CUtlSymbolLarge Name { get; }
  
  public ref CUtlSymbolLarge Value { get; }
  
  public IGameTime_t ExpirationTime { get; }
}