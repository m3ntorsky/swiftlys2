using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_WaterImpulseRenderer : IParticleFunctionRenderer {

  
  public IPerParticleVecInput Pos { get; }
  
  public IPerParticleFloatInput Radius { get; }
  
  public IPerParticleFloatInput Magnitude { get; }
  
  public IPerParticleFloatInput Shape { get; }
  
  public ref EventTypeSelection_t EventType { get; }
}