using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ExternalGameImpulseForce : IParticleFunctionForce {

  
  public IPerParticleFloatInput ForceScale { get; }
  
  public ref bool Ropes { get; }
  
  public ref bool RopesZOnly { get; }
  
  public ref bool Explosions { get; }
  
  public ref bool Particles { get; }
}