using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomColor : IParticleFunctionInitializer {

  public ref Color ColorMin { get; }
  
  public ref Color ColorMax { get; }
  
  public ref Color TintMin { get; }
  
  public ref Color TintMax { get; }
  
  public ref float TintPerc { get; }
  
  public ref float UpdateThreshold { get; }
  
  public ref int TintCP { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref ParticleColorBlendMode_t TintBlendMode { get; }
  
  public ref float LightAmplification { get; }
  
}