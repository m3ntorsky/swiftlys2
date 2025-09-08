using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStateUpdateData : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public IAnimScriptHandle Script { get; }
  
  public ref CUtlVector<int> TransitionIndices { get; }
  
  public ref CUtlVector Actions { get; }
  
  public IAnimStateID StateID { get; }
  
  public ISchemaUntypedField IsStartState { get; }
  
  public ISchemaUntypedField IsEndState { get; }
  
  public ISchemaUntypedField IsPassthrough { get; }
  
  public ISchemaUntypedField IsPassthroughRootMotion { get; }
  
  public ISchemaUntypedField PreEvaluatePassthroughTransitionPath { get; }
  
}