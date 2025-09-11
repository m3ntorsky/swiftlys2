using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_PositionOffset : IParticleFunctionInitializer {

  
  public IPerParticleVecInput OffsetMin { get; }
  
  public IPerParticleVecInput OffsetMax { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref bool LocalCoords { get; }
  
  public ref bool Proportional { get; }
  
  public IRandomNumberGeneratorParameters RandomnessParameters { get; }
}