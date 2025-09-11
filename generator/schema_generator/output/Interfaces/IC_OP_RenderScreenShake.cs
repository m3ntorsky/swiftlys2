using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderScreenShake : IParticleFunctionRenderer {

  
  public ref float DurationScale { get; }
  
  public ref float RadiusScale { get; }
  
  public ref float FrequencyScale { get; }
  
  public ref float AmplitudeScale { get; }
  
  public IParticleAttributeIndex_t RadiusField { get; }
  
  public IParticleAttributeIndex_t DurationField { get; }
  
  public IParticleAttributeIndex_t FrequencyField { get; }
  
  public IParticleAttributeIndex_t AmplitudeField { get; }
  
  public ref int FilterCP { get; }
}