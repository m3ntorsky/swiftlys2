using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerAmpedDecayingSineWave : IVoiceContainerDecayingSineWave {

  
  public ref float GainAmount { get; }
}