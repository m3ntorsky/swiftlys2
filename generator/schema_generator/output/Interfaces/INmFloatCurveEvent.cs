using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatCurveEvent : INmEvent {

  
  public ref CGlobalSymbol ID { get; }
  
  public ISchemaUntypedField Curve { get; }
}