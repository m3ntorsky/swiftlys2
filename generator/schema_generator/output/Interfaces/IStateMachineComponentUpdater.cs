using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStateMachineComponentUpdater : IAnimComponentUpdater {

  public IAnimStateMachineUpdater StateMachine { get; }
  
}