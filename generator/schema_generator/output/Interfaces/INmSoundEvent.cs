using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSoundEvent : INmEvent {

  public ref CNmEventRelevance_t Relevance { get; }
  
  public ref CNmSoundEvent::Type_t Type { get; }
  
  public ref CUtlString Name { get; }
  
  public ref CNmSoundEvent::Position_t Position { get; }
  
  public ref CUtlString AttachmentName { get; }
  
  public ref CUtlString Tags { get; }
  
  public ref bool IsServerOnly { get; }
  
  public ref bool ContinuePlayingSoundAtDurationEnd { get; }
  
  public ref float DurationInterruptionThreshold { get; }
  
}