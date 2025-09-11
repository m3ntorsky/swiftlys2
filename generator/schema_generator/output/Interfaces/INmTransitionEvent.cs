using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTransitionEvent : INmEvent {

  
  public ref NmTransitionRule_t Rule { get; }
  
  public ref CGlobalSymbol ID { get; }
}