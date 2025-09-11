using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitialVelocityNoise : IParticleFunctionInitializer {

  
  public ref Vector AbsVal { get; }
  
  public ref Vector AbsValInv { get; }
  
  public IPerParticleVecInput OffsetLoc { get; }
  
  public IPerParticleFloatInput Offset { get; }
  
  public IPerParticleVecInput OutputMin { get; }
  
  public IPerParticleVecInput OutputMax { get; }
  
  public IPerParticleFloatInput NoiseScale { get; }
  
  public IPerParticleFloatInput NoiseScaleLoc { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref bool IgnoreDt { get; }
}