using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateMachineNode__StateDefinition_t : ISchemaClass {

  
  public ref short StateNodeIdx { get; }
  
  public ref short EntryConditionNodeIdx { get; }
  
  public ref CUtlLeanVectorFixedGrowable<CNmStateMachineNode::TransitionDefinition_t,5> TransitionDefinitions { get; }
}