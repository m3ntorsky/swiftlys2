using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_InheritFromPeerSystem : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public ref int Increment { get; }
  
  public ref int GroupID { get; }
  
}