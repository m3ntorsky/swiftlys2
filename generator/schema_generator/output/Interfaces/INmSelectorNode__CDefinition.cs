using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSelectorNode__CDefinition : INmPoseNode::CDefinition {

  
  public ISchemaUntypedField OptionNodeIndices { get; }
  
  public ISchemaUntypedField ConditionNodeIndices { get; }
}