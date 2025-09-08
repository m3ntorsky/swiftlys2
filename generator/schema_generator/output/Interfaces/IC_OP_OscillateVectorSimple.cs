using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_OscillateVectorSimple : IParticleFunctionOperator {

  public ref Vector Rate { get; }
  
  public ref Vector Frequency { get; }
  
  public IParticleAttributeIndex_t Field { get; }
  
  public ref float OscMult { get; }
  
  public ref float OscAdd { get; }
  
  public ref bool Offset { get; }
  
}