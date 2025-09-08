using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionSetSoundeventParameterSchema : ISosGroupActionSchema {

  public ref int MaxCount { get; }
  
  public ref float MinValue { get; }
  
  public ref float MaxValue { get; }
  
  public ref CUtlString OpvarName { get; }
  
  public ref SosActionSortType_t SortType { get; }
  
}