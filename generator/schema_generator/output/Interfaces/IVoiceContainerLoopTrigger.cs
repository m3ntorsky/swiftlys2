using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerLoopTrigger : IVoiceContainerBase {

  public ISoundContainerReference Sound { get; }
  
  public ref float RetriggerTimeMin { get; }
  
  public ref float RetriggerTimeMax { get; }
  
  public ref float FadeTime { get; }
  
  public ref bool CrossFade { get; }
  
}