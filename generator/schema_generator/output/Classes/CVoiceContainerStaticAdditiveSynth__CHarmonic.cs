using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerStaticAdditiveSynth__CHarmonic : SchemaClass, IVoiceContainerStaticAdditiveSynth__CHarmonic {

  public CVoiceContainerStaticAdditiveSynth__CHarmonic(nint handle) : base(handle) {
  }

  public ref EWaveform Waveform {
    get => ref _Handle.AsRef<EWaveform>(Schema.GetOffset(0xC47956E906E0A8DE));
  }
  public ref EMidiNote Fundamental {
    get => ref _Handle.AsRef<EMidiNote>(Schema.GetOffset(0xC47956E9C45D876C));
  }
  public ref int Octave {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC47956E937F03859));
  }
  public ref float Cents {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC47956E98E027DCE));
  }
  public ref float Phase {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC47956E93C22A9CA));
  }
  public ISchemaUntypedField Curve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC47956E9BFFA0B34));
  }
  public IVoiceContainerStaticAdditiveSynth::CGainScalePerInstance VolumeScaling {
    get => new CVoiceContainerStaticAdditiveSynth::CGainScalePerInstance(_Handle + Schema.GetOffset(0xC47956E9820320D8));
  }


}