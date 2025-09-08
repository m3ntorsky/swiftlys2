using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ReadFromNeighboringParticle : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int Increment { get; }
  
  public IPerParticleFloatInput DistanceCheck { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
}