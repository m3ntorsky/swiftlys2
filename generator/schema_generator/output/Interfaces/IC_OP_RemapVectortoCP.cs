using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapVectortoCP : IParticleFunctionOperator {

  public ref int OutControlPointNumber { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public ref int ParticleNumber { get; }
  
}