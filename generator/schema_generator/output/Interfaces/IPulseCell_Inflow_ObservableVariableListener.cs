using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Inflow_ObservableVariableListener : IPulseCell_Inflow_BaseEntrypoint {

  public IPulseRuntimeBlackboardReferenceIndex_t BlackboardReference { get; }
  
  public ref bool SelfReference { get; }
  
}