using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ClientPhysics : IParticleFunctionRenderer {

  
  public ref CUtlString StrPhysicsType { get; }
  
  public ref bool StartAsleep { get; }
  
  public IParticleCollectionFloatInput PlayerWakeRadius { get; }
  
  public IParticleCollectionFloatInput VehicleWakeRadius { get; }
  
  public ref bool UseHighQualitySimulation { get; }
  
  public ref int MaxParticleCount { get; }
  
  public ref bool RespectExclusionVolumes { get; }
  
  public ref bool KillParticles { get; }
  
  public ref bool DeleteSim { get; }
  
  public ref int ControlPoint { get; }
  
  public ref int ForcedSimId { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
  public ref ParticleAttrBoxFlags_t ForcedStatusEffects { get; }
}