using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerSelector : IVoiceContainerBase {

  public ref PlayBackMode_t Mode { get; }
  
  public ISoundContainerReferenceArray SoundsToPlay { get; }
  
  public ref CUtlVector<float> ProbabilityWeights { get; }
  
}