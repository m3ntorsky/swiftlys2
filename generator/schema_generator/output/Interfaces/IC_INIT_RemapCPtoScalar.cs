using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RemapCPtoScalar : IParticleFunctionInitializer {

  
  public ref int CPInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int Field { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref float RemapBias { get; }
}