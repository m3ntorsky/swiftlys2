using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapTransformOrientationToRotations : IParticleFunctionOperator {

  public IParticleTransformInput TransformInput { get; }
  
  public ref Vector Rotation { get; }
  
  public ref bool UseQuat { get; }
  
  public ref bool WriteNormal { get; }
  
}