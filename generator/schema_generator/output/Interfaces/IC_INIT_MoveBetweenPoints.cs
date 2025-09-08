using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_MoveBetweenPoints : IParticleFunctionInitializer {

  public IPerParticleFloatInput SpeedMin { get; }
  
  public IPerParticleFloatInput SpeedMax { get; }
  
  public IPerParticleFloatInput EndSpread { get; }
  
  public IPerParticleFloatInput StartOffset { get; }
  
  public IPerParticleFloatInput EndOffset { get; }
  
  public ref int EndControlPointNumber { get; }
  
  public ref bool TrailBias { get; }
  
}