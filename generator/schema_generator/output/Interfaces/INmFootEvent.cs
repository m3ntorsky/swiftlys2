using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFootEvent : INmEvent {

  public ref NmFootPhase_t Phase { get; }
  
}