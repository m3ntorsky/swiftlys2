using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionLimitSchema : ISosGroupActionSchema {

  public ref int MaxCount { get; }
  
  public ref SosActionStopType_t StopType { get; }
  
  public ref SosActionSortType_t SortType { get; }
  
}