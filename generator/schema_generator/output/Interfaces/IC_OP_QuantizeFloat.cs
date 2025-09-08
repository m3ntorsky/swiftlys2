using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_QuantizeFloat : IParticleFunctionOperator {

  public IPerParticleFloatInput InputValue { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
}