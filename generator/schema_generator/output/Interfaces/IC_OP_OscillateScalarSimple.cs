using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_OscillateScalarSimple : IParticleFunctionOperator {

  public ref float Rate { get; }
  
  public ref float Frequency { get; }
  
  public IParticleAttributeIndex_t Field { get; }
  
  public ref float OscMult { get; }
  
  public ref float OscAdd { get; }
  
}