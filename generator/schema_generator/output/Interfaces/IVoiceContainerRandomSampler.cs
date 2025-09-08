using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerRandomSampler : IVoiceContainerBase {

  public ref float Amplitude { get; }
  
  public ref float AmplitudeJitter { get; }
  
  public ref float TimeJitter { get; }
  
  public ref float MaxLength { get; }
  
  public ref int NumDelayVariations { get; }
  
  public ref CUtlVector GrainResources { get; }
  
}