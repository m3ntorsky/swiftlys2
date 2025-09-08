using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapParticleCountOnScalarEndCap : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int InputMin { get; }
  
  public ref int InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref bool Backwards { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
}