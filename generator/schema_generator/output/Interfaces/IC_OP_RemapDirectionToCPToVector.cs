using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapDirectionToCPToVector : IParticleFunctionOperator {

  
  public ref int CP { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float Scale { get; }
  
  public ref float OffsetRot { get; }
  
  public ref Vector OffsetAxis { get; }
  
  public ref bool Normalize { get; }
  
  public IParticleAttributeIndex_t FieldStrength { get; }
}