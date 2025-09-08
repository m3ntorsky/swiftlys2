using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvSoundscapeProxy : CEnvSoundscape, IEnvSoundscapeProxy {

  public CEnvSoundscapeProxy(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge MainSoundscapeName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x58127BA672404420));
  }


}