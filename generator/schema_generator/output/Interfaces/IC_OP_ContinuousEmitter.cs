using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ContinuousEmitter : IParticleFunctionEmitter {

  public IParticleCollectionFloatInput EmissionDuration { get; }
  
  public IParticleCollectionFloatInput StartTime { get; }
  
  public IParticleCollectionFloatInput EmitRate { get; }
  
  public ref float EmissionScale { get; }
  
  public ref float ScalePerParentParticle { get; }
  
  public ref bool InitFromKilledParentParticles { get; }
  
  public ref EventTypeSelection_t EventType { get; }
  
  public ref int SnapshotControlPoint { get; }
  
  public ref CUtlString StrSnapshotSubset { get; }
  
  public ref int LimitPerUpdate { get; }
  
  public ref bool ForceEmitOnFirstUpdate { get; }
  
  public ref bool ForceEmitOnLastUpdate { get; }
  
}