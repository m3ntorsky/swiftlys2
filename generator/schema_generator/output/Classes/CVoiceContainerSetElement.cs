using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerSetElement : SchemaClass, IVoiceContainerSetElement {

  public CVoiceContainerSetElement(nint handle) : base(handle) {
  }

  public CVoiceContainerSetElement(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISoundContainerReference Sound {
    get => new CSoundContainerReference(_Handle + Schema.GetOffset(0x1280027B4E1C4FB4));
  }
  public ref float VolumeDB {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1280027B3197E3EF));
  }


}