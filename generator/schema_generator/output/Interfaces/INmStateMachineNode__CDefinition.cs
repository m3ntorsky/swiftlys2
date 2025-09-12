using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateMachineNode__CDefinition : INmPoseNode::CDefinition {

  
  public ISchemaUntypedField StateDefinitions { get; }
  
  public ref short DefaultStateIndex { get; }
}