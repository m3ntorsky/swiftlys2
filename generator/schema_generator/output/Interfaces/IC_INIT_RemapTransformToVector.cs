using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RemapTransformToVector : IParticleFunctionInitializer {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref Vector InputMin { get; }
  
  public ref Vector InputMax { get; }
  
  public ref Vector OutputMin { get; }
  
  public ref Vector OutputMax { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public IParticleTransformInput LocalSpaceTransform { get; }
  
  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool Offset { get; }
  
  public ref bool Accelerate { get; }
  
  public ref float RemapBias { get; }
  
}