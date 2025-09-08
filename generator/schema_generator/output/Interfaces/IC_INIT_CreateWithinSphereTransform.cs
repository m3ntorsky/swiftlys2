using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateWithinSphereTransform : IParticleFunctionInitializer {

  public IPerParticleFloatInput RadiusMin { get; }
  
  public IPerParticleFloatInput RadiusMax { get; }
  
  public IPerParticleVecInput DistanceBias { get; }
  
  public ref Vector DistanceBiasAbs { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public IPerParticleFloatInput SpeedMin { get; }
  
  public IPerParticleFloatInput SpeedMax { get; }
  
  public ref float SpeedRandExp { get; }
  
  public ref bool LocalCoords { get; }
  
  public ref float EndCPGrowthTime { get; }
  
  public IPerParticleVecInput LocalCoordinateSystemSpeedMin { get; }
  
  public IPerParticleVecInput LocalCoordinateSystemSpeedMax { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleAttributeIndex_t FieldVelocity { get; }
  
}