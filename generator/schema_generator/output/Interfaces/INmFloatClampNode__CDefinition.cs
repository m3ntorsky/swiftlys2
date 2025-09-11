using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatClampNode__CDefinition : INmFloatValueNode::CDefinition {

  
  public ref short InputValueNodeIdx { get; }
  
  public ISchemaUntypedField ClampRange { get; }
}