using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_NormalAlignToCP : IParticleFunctionInitializer {

  
  public IParticleTransformInput TransformInput { get; }
  
  public ref ParticleControlPointAxis_t ControlPointAxis { get; }
}