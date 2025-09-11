using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetCPtoVector : IParticleFunctionOperator {

  
  public ref int CPInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
}