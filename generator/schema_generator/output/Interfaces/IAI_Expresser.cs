using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAI_Expresser : ISchemaClass {

  
  public IGameTime_t StopTalkTime { get; }
  
  public IGameTime_t StopTalkTimeWithoutDelay { get; }
  
  public IGameTime_t QueuedSpeechTime { get; }
  
  public IGameTime_t BlockedTalkTime { get; }
  
  public ref int VoicePitch { get; }
  
  public IGameTime_t LastTimeAcceptedSpeak { get; }
  
  public ref bool AllowSpeakingInterrupts { get; }
  
  public ref bool ConsiderSceneInvolvementAsSpeech { get; }
  
  public ref bool SceneEntityDisabled { get; }
  
  public ref int LastSpokenPriority { get; }
  
  public IBaseFlex Outer { get; }
}