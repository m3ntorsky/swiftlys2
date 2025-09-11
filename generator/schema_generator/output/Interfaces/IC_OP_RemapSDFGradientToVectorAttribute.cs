using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapSDFGradientToVectorAttribute : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
}