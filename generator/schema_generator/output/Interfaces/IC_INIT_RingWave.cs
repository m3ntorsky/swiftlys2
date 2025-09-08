using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RingWave : IParticleFunctionInitializer {

  public IParticleTransformInput TransformInput { get; }
  
  public IParticleCollectionFloatInput ParticlesPerOrbit { get; }
  
  public IPerParticleFloatInput InitialRadius { get; }
  
  public IPerParticleFloatInput Thickness { get; }
  
  public IPerParticleFloatInput InitialSpeedMin { get; }
  
  public IPerParticleFloatInput InitialSpeedMax { get; }
  
  public IPerParticleFloatInput Roll { get; }
  
  public IPerParticleFloatInput Pitch { get; }
  
  public IPerParticleFloatInput Yaw { get; }
  
  public ref bool EvenDistribution { get; }
  
  public ref bool XYVelocityOnly { get; }
  
}