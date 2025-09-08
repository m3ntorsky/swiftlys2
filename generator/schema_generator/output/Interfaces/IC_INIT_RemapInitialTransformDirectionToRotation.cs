using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RemapInitialTransformDirectionToRotation : IParticleFunctionInitializer {

  public IParticleTransformInput TransformInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float OffsetRot { get; }
  
  public ref int Component { get; }
  
}