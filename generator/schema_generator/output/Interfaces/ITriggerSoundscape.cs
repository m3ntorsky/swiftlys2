using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerSoundscape : IBaseTrigger {

  public ref CHandle<CEnvSoundscapeTriggerable> Soundscape { get; }
  
  public ref CUtlSymbolLarge SoundscapeName { get; }
  
  public ref CUtlVector<CHandle<CBasePlayerPawn>> Spectators { get; }
  
}