using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterClass : IBaseFilter {

  
  public ref CUtlSymbolLarge FilterClass { get; }
}