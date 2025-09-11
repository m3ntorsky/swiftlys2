using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_GameDecalRenderer : IParticleFunctionRenderer {

  
  public ref CGlobalSymbol DecalGroupName { get; }
  
  public ref EventTypeSelection_t EventType { get; }
  
  public ref ParticleCollisionMask_t InteractionMask { get; }
  
  public ref ParticleCollisionGroup_t CollisionGroup { get; }
  
  public IPerParticleVecInput StartPos { get; }
  
  public IPerParticleVecInput EndPos { get; }
  
  public IPerParticleFloatInput TraceBloat { get; }
  
  public IPerParticleFloatInput DecalSize { get; }
  
  public IPerParticleFloatInput DecalGroupIndex { get; }
  
  public IPerParticleFloatInput DecalRotation { get; }
  
  public IPerParticleVecInput ModulationColor { get; }
  
  public ref bool UseGameDefaultDecalSize { get; }
  
  public ref bool RandomDecalRotation { get; }
  
  public ref bool RandomlySelectDecalInGroup { get; }
  
  public ref bool NoDecalsOnOwner { get; }
  
  public ref bool VisualizeTraces { get; }
}