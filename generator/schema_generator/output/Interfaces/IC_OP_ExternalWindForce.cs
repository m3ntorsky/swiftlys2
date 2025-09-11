using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ExternalWindForce : IParticleFunctionForce {

  
  public IPerParticleVecInput SamplePosition { get; }
  
  public IPerParticleVecInput Scale { get; }
  
  public ref bool SampleWind { get; }
  
  public ref bool SampleWater { get; }
  
  public ref bool DampenNearWaterPlane { get; }
  
  public ref bool SampleGravity { get; }
  
  public IPerParticleVecInput GravityForce { get; }
  
  public ref bool UseBasicMovementGravity { get; }
  
  public IPerParticleFloatInput LocalGravityScale { get; }
  
  public IPerParticleFloatInput LocalBuoyancyScale { get; }
  
  public IPerParticleVecInput BuoyancyForce { get; }
}