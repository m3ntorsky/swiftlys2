using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerSwitch : CVoiceContainerBase, IVoiceContainerSwitch {

  public CVoiceContainerSwitch(nint handle) : base(handle) {
  }

  public ref CUtlVector SoundsToPlay {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x79EA569BDCB5F70E));
  }


}