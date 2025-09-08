using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerEnvelope : IVoiceContainerBase {

  public ref CStrongHandle<InfoForResourceTypeCVoiceContainerBase> Sound { get; }
  
  public IVoiceContainerAnalysisBase AnalysisContainer { get; }
  
}