using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapCPVelocityToVector : IParticleFunctionOperator {

  public ref int ControlPoint { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float Scale { get; }
  
  public ref bool Normalize { get; }
  
}