using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAI_ChangeHintGroup : IBaseEntity {

  
  public ref int SearchType { get; }
  
  public ref CUtlSymbolLarge StrSearchName { get; }
  
  public ref CUtlSymbolLarge StrNewHintGroup { get; }
  
  public ref float Radius { get; }
}