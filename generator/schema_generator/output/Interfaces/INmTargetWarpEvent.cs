using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTargetWarpEvent : INmEvent {

  
  public ref NmTargetWarpRule_t Rule { get; }
  
  public ref NmTargetWarpAlgorithm_t Algorithm { get; }
}