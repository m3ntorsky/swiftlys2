using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_BasicMovement : IParticleFunctionOperator {

  public IParticleCollectionVecInput Gravity { get; }
  
  public IParticleCollectionFloatInput Drag { get; }
  
  public IParticleMassCalculationParameters MassControls { get; }
  
  public ref int MaxConstraintPasses { get; }
  
  public ref bool UseNewCode { get; }
  
}