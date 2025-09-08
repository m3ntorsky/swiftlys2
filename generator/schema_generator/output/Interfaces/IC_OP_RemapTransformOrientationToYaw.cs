using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapTransformOrientationToYaw : IParticleFunctionOperator {

  public IParticleTransformInput TransformInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float RotOffset { get; }
  
  public ref float SpinStrength { get; }
  
}