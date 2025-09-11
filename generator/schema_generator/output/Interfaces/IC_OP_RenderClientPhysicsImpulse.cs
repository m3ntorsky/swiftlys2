using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderClientPhysicsImpulse : IParticleFunctionRenderer {

  
  public IPerParticleFloatInput Radius { get; }
  
  public IPerParticleFloatInput Magnitude { get; }
  
  public ref int SimIdFilter { get; }
}