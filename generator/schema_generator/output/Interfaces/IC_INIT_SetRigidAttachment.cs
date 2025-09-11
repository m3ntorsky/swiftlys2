using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_SetRigidAttachment : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref bool LocalSpace { get; }
}