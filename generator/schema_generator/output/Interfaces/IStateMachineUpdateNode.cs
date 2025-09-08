using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStateMachineUpdateNode : IAnimUpdateNodeBase {

  public IAnimStateMachineUpdater StateMachine { get; }
  
  public ref CUtlVector StateData { get; }
  
  public ref CUtlVector TransitionData { get; }
  
  public ref bool BlockWaningTags { get; }
  
  public ref bool LockStateWhenWaning { get; }
  
  public ref bool ResetWhenActivated { get; }
  
}