using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventParameter : IBaseEntity {

  public ref CUtlSymbolLarge ParamName { get; }
  
  public ref float FloatValue { get; }
  
}