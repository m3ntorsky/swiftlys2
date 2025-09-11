using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapGravityToVector : IParticleFunctionOperator {

  
  public IPerParticleVecInput Input1 { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool NormalizedOutput { get; }
}