using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_ExampleSelector : IPulseCell_BaseFlow {

  public IPulseSelectorOutflowList_t OutflowList { get; }
  
}