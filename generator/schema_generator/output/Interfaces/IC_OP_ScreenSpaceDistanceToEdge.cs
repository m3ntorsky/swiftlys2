using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ScreenSpaceDistanceToEdge : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleFloatInput MaxDistFromEdge { get; }
  
  public IParticleRemapFloatInput OutputRemap { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
}