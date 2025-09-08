using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IOrnamentProp : IDynamicProp {

  public ref CUtlSymbolLarge InitialOwner { get; }
  
}