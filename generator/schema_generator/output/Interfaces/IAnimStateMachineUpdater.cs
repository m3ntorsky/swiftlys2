using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimStateMachineUpdater : ISchemaClass {

  
// CUtlVector< CStateUpdateData >
  public ref CUtlVector States { get; }
  
// CUtlVector< CTransitionUpdateData >
  public ref CUtlVector Transitions { get; }
  
  public ref int StartStateIndex { get; }
}