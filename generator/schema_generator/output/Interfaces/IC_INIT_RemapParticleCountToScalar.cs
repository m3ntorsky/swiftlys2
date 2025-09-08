using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RemapParticleCountToScalar : IParticleFunctionInitializer {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int InputMin { get; }
  
  public ref int InputMax { get; }
  
  public ref int ScaleControlPoint { get; }
  
  public ref int ScaleControlPointField { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool ActiveRange { get; }
  
  public ref bool Invert { get; }
  
  public ref bool Wrap { get; }
  
  public ref float RemapBias { get; }
  
}