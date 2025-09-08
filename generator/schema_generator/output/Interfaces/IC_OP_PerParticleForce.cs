using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PerParticleForce : IParticleFunctionForce {

  public IPerParticleFloatInput ForceScale { get; }
  
  public IPerParticleVecInput Force { get; }
  
  public ref int CP { get; }
  
}