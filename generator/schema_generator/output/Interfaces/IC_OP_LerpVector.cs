using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LerpVector : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref Vector Output { get; }
  
  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
}