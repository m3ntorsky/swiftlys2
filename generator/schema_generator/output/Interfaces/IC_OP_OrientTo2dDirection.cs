using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_OrientTo2dDirection : IParticleFunctionOperator {

  public ref float RotOffset { get; }
  
  public ref float SpinStrength { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
}