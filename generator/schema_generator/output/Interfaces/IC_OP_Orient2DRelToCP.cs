using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_Orient2DRelToCP : IParticleFunctionOperator {

  public ref float RotOffset { get; }
  
  public ref float SpinStrength { get; }
  
  public ref int CP { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
}