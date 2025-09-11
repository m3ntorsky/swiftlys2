using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_InstantaneousEmitter : IParticleFunctionEmitter {

  
  public IParticleCollectionFloatInput ParticlesToEmit { get; }
  
  public IParticleCollectionFloatInput StartTime { get; }
  
  public ref float InitFromKilledParentParticles { get; }
  
  public ref EventTypeSelection_t EventType { get; }
  
  public IParticleCollectionFloatInput ParentParticleScale { get; }
  
  public ref int MaxEmittedPerFrame { get; }
  
  public ref int SnapshotControlPoint { get; }
  
  public ref CUtlString StrSnapshotSubset { get; }
}