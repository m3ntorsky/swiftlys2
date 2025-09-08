using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CollideWithSelf : IParticleFunctionConstraint {

  public IPerParticleFloatInput RadiusScale { get; }
  
  public IPerParticleFloatInput MinimumSpeed { get; }
  
}