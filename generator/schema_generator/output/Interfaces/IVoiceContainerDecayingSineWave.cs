using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerDecayingSineWave : IVoiceContainerBase {

  
  public ref float Frequency { get; }
  
  public ref float DecayTime { get; }
}