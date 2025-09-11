using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ColorInterpolate : IParticleFunctionOperator {

  
  public ref Color ColorFade { get; }
  
  public ref float FadeStartTime { get; }
  
  public ref float FadeEndTime { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref bool EaseInOut { get; }
}