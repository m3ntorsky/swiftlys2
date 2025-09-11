using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SpringToVectorConstraint : IParticleFunctionConstraint {

  
  public IPerParticleFloatInput RestLength { get; }
  
  public IPerParticleFloatInput MinDistance { get; }
  
  public IPerParticleFloatInput MaxDistance { get; }
  
  public IPerParticleFloatInput RestingLength { get; }
  
  public IPerParticleVecInput AnchorVector { get; }
}