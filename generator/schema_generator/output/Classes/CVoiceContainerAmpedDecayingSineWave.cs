using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerAmpedDecayingSineWave : CVoiceContainerDecayingSineWave, IVoiceContainerAmpedDecayingSineWave {

  public CVoiceContainerAmpedDecayingSineWave(nint handle) : base(handle) {
  }

  public CVoiceContainerAmpedDecayingSineWave(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float GainAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x312CFD9CB3BC88F4));
  }


}