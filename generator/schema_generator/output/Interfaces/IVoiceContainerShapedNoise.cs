using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerShapedNoise : IVoiceContainerBase {

  
  public ref bool UseCurveForFrequency { get; }
  
  public ref float Frequency { get; }
  
  public ISchemaUntypedField FrequencySweep { get; }
  
  public ref bool UseCurveForResonance { get; }
  
  public ref float Resonance { get; }
  
  public ISchemaUntypedField ResonanceSweep { get; }
  
  public ref bool UseCurveForAmplitude { get; }
  
  public ref float GainInDecibels { get; }
  
  public ISchemaUntypedField GainSweep { get; }
}