using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerSet : CVoiceContainerBase, IVoiceContainerSet {

  public CVoiceContainerSet(nint handle) : base(handle) {
  }

  public CVoiceContainerSet(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CVoiceContainerSetElement > SoundsToPlay {
    get => ref _Handle.AsRef<CUtlVector< CVoiceContainerSetElement >>(Schema.GetOffset(0xA07D279DCB5F70E));
  }


}