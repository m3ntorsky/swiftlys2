using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFrameSnapEvent : INmEvent {

  
  public ref NmFrameSnapEventMode_t FrameSnapMode { get; }
}