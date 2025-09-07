using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerSwitch : CVoiceContainerBase, IVoiceContainerSwitch {

  public CVoiceContainerSwitch(nint handle) : base(handle) {
  }

  public CVoiceContainerSwitch(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSoundContainerReference > SoundsToPlay {
    get => ref _Handle.AsRef<CUtlVector< CSoundContainerReference >>(Schema.GetOffset(0x79EA569BDCB5F70E));
  }


}