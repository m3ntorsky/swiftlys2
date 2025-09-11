using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateWithinBox : IParticleFunctionInitializer {

  
  public IPerParticleVecInput Min { get; }
  
  public IPerParticleVecInput Max { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool LocalSpace { get; }
  
  public IRandomNumberGeneratorParameters RandomnessParameters { get; }
  
  public ref bool UseNewCode { get; }
}