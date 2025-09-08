using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateMachineNode__CDefinition : INmPoseNode::CDefinition {

  public ref CUtlLeanVectorFixedGrowable<CNmStateMachineNode::StateDefinition_t,5> StateDefinitions { get; }
  
  public ref short DefaultStateIndex { get; }
  
}