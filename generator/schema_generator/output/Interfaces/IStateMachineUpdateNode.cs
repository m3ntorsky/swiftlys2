using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStateMachineUpdateNode : IAnimUpdateNodeBase {

  
  public IAnimStateMachineUpdater StateMachine { get; }
  
// CUtlVector< CStateNodeStateData >
  public ref CUtlVector StateData { get; }
  
// CUtlVector< CStateNodeTransitionData >
  public ref CUtlVector TransitionData { get; }
  
  public ref bool BlockWaningTags { get; }
  
  public ref bool LockStateWhenWaning { get; }
  
  public ref bool ResetWhenActivated { get; }
}