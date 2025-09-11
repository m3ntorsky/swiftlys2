using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_VelocityRadialRandom : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public IPerParticleFloatInput SpeedMin { get; }
  
  public IPerParticleFloatInput SpeedMax { get; }
  
  public ref Vector LocalCoordinateSystemSpeedScale { get; }
  
  public ref bool IgnoreDelta { get; }
}