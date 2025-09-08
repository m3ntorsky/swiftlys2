using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_BooleanSwitchState : IPulseCell_BaseState {

  public IPulseObservableBoolExpression_t Condition { get; }
  
  public IPulse_OutflowConnection SubGraph { get; }
  
  public IPulse_OutflowConnection WhenTrue { get; }
  
  public IPulse_OutflowConnection WhenFalse { get; }
  
}