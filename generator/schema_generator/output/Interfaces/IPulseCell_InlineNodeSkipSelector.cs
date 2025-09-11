using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_InlineNodeSkipSelector : IPulseCell_BaseFlow {

  
  public IPulseDocNodeID_t FlowNodeID { get; }
  
  public ref bool And { get; }
  
  public IPulseSelectorOutflowList_t PassOutflow { get; }
  
  public IPulse_OutflowConnection FailOutflow { get; }
}