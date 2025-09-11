using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterAttributeInt : IBaseFilter {

  
  public ref CUtlSymbolLarge AttributeName { get; }
}