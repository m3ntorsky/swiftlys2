using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerSoundscape : CBaseTrigger, ITriggerSoundscape {

  public CTriggerSoundscape(nint handle) : base(handle) {
  }

  public CHandle<IEnvSoundscapeTriggerable> Soundscape {
    get => new CHandle<CEnvSoundscapeTriggerable>(_Handle + Schema.GetOffset(0xA8ED7219EF1F0180));
  }
  public ref CUtlSymbolLarge SoundscapeName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xA8ED7219BDF7AA81));
  }
  public ref CUtlVector Spectators {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA8ED7219149EB35B));
  }


}