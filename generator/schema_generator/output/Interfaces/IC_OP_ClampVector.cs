using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ClampVector : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleVecInput OutputMin { get; }
  
  public IPerParticleVecInput OutputMax { get; }
  
}