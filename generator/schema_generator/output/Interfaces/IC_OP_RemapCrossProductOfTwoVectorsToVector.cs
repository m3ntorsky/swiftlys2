using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapCrossProductOfTwoVectorsToVector : IParticleFunctionOperator {

  public IPerParticleVecInput InputVec1 { get; }
  
  public IPerParticleVecInput InputVec2 { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref bool Normalize { get; }
  
}