using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerGranulator : IVoiceContainerBase {

  public ref float GrainLength { get; }
  
  public ref float GrainCrossfadeAmount { get; }
  
  public ref float StartJitter { get; }
  
  public ref float PlaybackJitter { get; }
  
  public ref bool ShouldWraparound { get; }
  
  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> SourceAudio { get; }
  
}