using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerShapedNoise : CVoiceContainerBase, IVoiceContainerShapedNoise {

  public CVoiceContainerShapedNoise(nint handle) : base(handle) {
  }

  public ref bool UseCurveForFrequency {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC58213629099DACC));
  }
  public ref float Frequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC5821362D2C16DD7));
  }
  public ISchemaUntypedField FrequencySweep {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC5821362B670CD0F));
  }
  public ref bool UseCurveForResonance {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC582136265C91FBE));
  }
  public ref float Resonance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC582136283BEE2DD));
  }
  public ISchemaUntypedField ResonanceSweep {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC582136250CFD679));
  }
  public ref bool UseCurveForAmplitude {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC5821362F8970DD3));
  }
  public ref float GainInDecibels {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC5821362528C3F88));
  }
  public ISchemaUntypedField GainSweep {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC582136246A13F7A));
  }


}