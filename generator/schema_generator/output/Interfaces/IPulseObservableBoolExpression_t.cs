using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseObservableBoolExpression_t : ISchemaClass {

  
  public IPulse_OutflowConnection EvaluateConnection { get; }
  
// CUtlVector< PulseRuntimeVarIndex_t >
  public ref CUtlVector DependentObservableVars { get; }
  
// CUtlVector< PulseRuntimeBlackboardReferenceIndex_t >
  public ref CUtlVector DependentObservableBlackboardReferences { get; }
}