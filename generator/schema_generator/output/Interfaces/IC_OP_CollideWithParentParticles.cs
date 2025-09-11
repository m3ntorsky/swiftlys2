using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CollideWithParentParticles : IParticleFunctionConstraint {

  
  public IPerParticleFloatInput ParentRadiusScale { get; }
  
  public IPerParticleFloatInput RadiusScale { get; }
}