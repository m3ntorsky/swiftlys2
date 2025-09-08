using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapVelocityToVector : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float Scale { get; }
  
  public ref bool Normalize { get; }
  
}