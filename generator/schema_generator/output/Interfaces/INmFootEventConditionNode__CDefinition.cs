using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFootEventConditionNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref short SourceStateNodeIdx { get; }
  
  public ref NmFootPhaseCondition_t PhaseCondition { get; }
  
  public INmBitFlags EventConditionRules { get; }
}