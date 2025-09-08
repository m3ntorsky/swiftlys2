using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RemapScalarToVector : IParticleFunctionInitializer {

  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref Vector OutputMin { get; }
  
  public ref Vector OutputMax { get; }
  
  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool LocalCoords { get; }
  
  public ref float RemapBias { get; }
  
}