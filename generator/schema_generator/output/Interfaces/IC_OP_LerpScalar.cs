using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LerpScalar : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleFloatInput Output { get; }
  
  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
}