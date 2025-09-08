using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitialSequenceFromModel : IParticleFunctionInitializer {

  public ref int ControlPointNumber { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleAttributeIndex_t FieldOutputAnim { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
}