using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LazyCullCompareFloat : IParticleFunctionOperator {

  public IPerParticleFloatInput Comparsion1 { get; }
  
  public IPerParticleFloatInput Comparsion2 { get; }
  
  public IPerParticleFloatInput CullTime { get; }
  
}