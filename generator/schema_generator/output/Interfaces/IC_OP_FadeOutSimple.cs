using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_FadeOutSimple : IParticleFunctionOperator {

  public ref float FadeOutTime { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
}