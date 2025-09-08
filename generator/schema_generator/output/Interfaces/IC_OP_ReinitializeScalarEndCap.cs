using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ReinitializeScalarEndCap : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
}