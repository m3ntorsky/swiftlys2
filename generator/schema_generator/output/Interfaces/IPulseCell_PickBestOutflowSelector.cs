using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_PickBestOutflowSelector : IPulseCell_BaseFlow {

  public ref PulseBestOutflowRules_t CheckType { get; }
  
  public IPulseSelectorOutflowList_t OutflowList { get; }
  
}