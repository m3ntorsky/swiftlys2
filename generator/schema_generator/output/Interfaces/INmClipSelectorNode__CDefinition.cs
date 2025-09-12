using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmClipSelectorNode__CDefinition : INmClipReferenceNode::CDefinition {

  
  public ISchemaUntypedField OptionNodeIndices { get; }
  
  public ISchemaUntypedField ConditionNodeIndices { get; }
}