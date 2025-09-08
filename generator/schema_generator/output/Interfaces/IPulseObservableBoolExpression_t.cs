using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseObservableBoolExpression_t : ISchemaClass {

  public IPulse_OutflowConnection EvaluateConnection { get; }
  
  public ref CUtlVector DependentObservableVars { get; }
  
  public ref CUtlVector DependentObservableBlackboardReferences { get; }
  
}