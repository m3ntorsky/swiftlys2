using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitFromVectorFieldSnapshot : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public ref int LocalSpaceCP { get; }
  
  public ref int WeightUpdateCP { get; }
  
  public ref bool UseVerticalVelocity { get; }
  
  public IPerParticleVecInput Scale { get; }
}