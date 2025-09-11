using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerEnvelopeAnalyzer : IVoiceContainerAnalysisBase {

  
  public ref EMode_t Mode { get; }
  
  public ref float AnalysisWindowMs { get; }
  
  public ref float Threshold { get; }
}