using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTransitionEventConditionNode__CDefinition : INmBoolValueNode::CDefinition {

  public ref CGlobalSymbol RequireRuleID { get; }
  
  public INmBitFlags EventConditionRules { get; }
  
  public ref short SourceStateNodeIdx { get; }
  
  public ref NmTransitionRuleCondition_t RuleCondition { get; }
  
}