using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerStaticAdditiveSynth : IVoiceContainerBase {

  public ref CUtlVector Tones { get; }
  
}