using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CurlNoiseForce : IParticleFunctionForce {

  
  public ref ParticleDirectionNoiseType_t NoiseType { get; }
  
  public IPerParticleVecInput NoiseFreq { get; }
  
  public IPerParticleVecInput NoiseScale { get; }
  
  public IPerParticleVecInput Offset { get; }
  
  public IPerParticleVecInput OffsetRate { get; }
  
  public IPerParticleFloatInput WorleySeed { get; }
  
  public IPerParticleFloatInput WorleyJitter { get; }
}