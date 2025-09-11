using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_VelocityFromCP : IParticleFunctionInitializer {

  
  public IParticleCollectionVecInput VelocityInput { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref float VelocityScale { get; }
  
  public ref bool DirectionOnly { get; }
}