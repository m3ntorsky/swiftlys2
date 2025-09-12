using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIDToFloatNode__CDefinition : INmFloatValueNode::CDefinition {

  
  public ref short InputValueNodeIdx { get; }
  
  public ref float DefaultValue { get; }
  
  public ISchemaUntypedField IDs { get; }
  
  public ISchemaUntypedField Values { get; }
}