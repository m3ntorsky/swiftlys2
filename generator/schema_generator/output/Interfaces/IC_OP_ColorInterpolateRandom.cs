using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ColorInterpolateRandom : IParticleFunctionOperator {

  
  public ref Color ColorFadeMin { get; }
  
  public ref Color ColorFadeMax { get; }
  
  public ref float FadeStartTime { get; }
  
  public ref float FadeEndTime { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref bool EaseInOut { get; }
}