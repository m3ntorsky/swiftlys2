using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LerpToOtherAttribute : IParticleFunctionOperator {

  
  public IPerParticleFloatInput Interpolation { get; }
  
  public IParticleAttributeIndex_t FieldInputFrom { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
}