using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_VelocityRandom : IParticleFunctionInitializer {

  public ref int ControlPointNumber { get; }
  
  public IPerParticleFloatInput SpeedMin { get; }
  
  public IPerParticleFloatInput SpeedMax { get; }
  
  public IPerParticleVecInput LocalCoordinateSystemSpeedMin { get; }
  
  public IPerParticleVecInput LocalCoordinateSystemSpeedMax { get; }
  
  public ref bool IgnoreDT { get; }
  
  public IRandomNumberGeneratorParameters RandomnessParameters { get; }
  
}