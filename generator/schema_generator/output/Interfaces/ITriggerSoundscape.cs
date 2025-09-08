using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerSoundscape : IBaseTrigger {

  public CHandle<IEnvSoundscapeTriggerable> Soundscape { get; }
  
  public ref CUtlSymbolLarge SoundscapeName { get; }
  
  public ref CUtlVector Spectators { get; }
  
}