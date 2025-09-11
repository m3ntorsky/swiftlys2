using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_InheritFromParentParticles : IParticleFunctionOperator {

  
  public ref float Scale { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int Increment { get; }
  
  public ref bool RandomDistribution { get; }
}