using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LerpEndCapScalar : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float Output { get; }
  
  public ref float LerpTime { get; }
}