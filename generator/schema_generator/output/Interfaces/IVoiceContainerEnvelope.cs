using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerEnvelope : IVoiceContainerBase {

  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> Sound { get; }
  
  public IVoiceContainerAnalysisBase AnalysisContainer { get; }
  
}