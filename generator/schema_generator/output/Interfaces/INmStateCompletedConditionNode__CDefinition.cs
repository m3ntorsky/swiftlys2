using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateCompletedConditionNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref short SourceStateNodeIdx { get; }
  
  public ref short TransitionDurationOverrideNodeIdx { get; }
  
  public ref float TransitionDurationSeconds { get; }
}