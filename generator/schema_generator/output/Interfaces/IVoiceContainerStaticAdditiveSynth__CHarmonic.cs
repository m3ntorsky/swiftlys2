using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerStaticAdditiveSynth__CHarmonic : ISchemaClass {

  
  public ref EWaveform Waveform { get; }
  
  public ref EMidiNote Fundamental { get; }
  
  public ref int Octave { get; }
  
  public ref float Cents { get; }
  
  public ref float Phase { get; }
  
  public ISchemaUntypedField Curve { get; }
  
  public IVoiceContainerStaticAdditiveSynth::CGainScalePerInstance VolumeScaling { get; }
}