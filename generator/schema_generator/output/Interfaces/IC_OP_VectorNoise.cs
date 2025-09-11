using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_VectorNoise : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref Vector OutputMin { get; }
  
  public ref Vector OutputMax { get; }
  
  public ref float Fl4NoiseScale { get; }
  
  public ref bool Additive { get; }
  
  public ref bool Offset { get; }
  
  public ref float NoiseAnimationTimeScale { get; }
}