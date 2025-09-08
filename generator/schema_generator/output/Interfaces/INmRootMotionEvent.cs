using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmRootMotionEvent : INmEvent {

  public ref float BlendTimeSeconds { get; }
  
}