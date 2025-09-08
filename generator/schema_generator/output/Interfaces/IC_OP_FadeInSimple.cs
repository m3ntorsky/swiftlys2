using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_FadeInSimple : IParticleFunctionOperator {

  public ref float FadeInTime { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
}