using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmMaterialAttributeEvent : INmEvent {

  public ref CUtlString AttributeName { get; }
  
  public ref CUtlStringToken AttributeNameToken { get; }
  
  public ISchemaUntypedField X { get; }
  
  public ISchemaUntypedField Y { get; }
  
  public ISchemaUntypedField Z { get; }
  
  public ISchemaUntypedField W { get; }
  
}