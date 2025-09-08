using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MovementRotateParticleAroundAxis : IParticleFunctionOperator {

  public IParticleCollectionVecInput RotAxis { get; }
  
  public IParticleCollectionFloatInput RotRate { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref bool LocalSpace { get; }
  
}