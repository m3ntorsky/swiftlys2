using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IReplicationParameters : ISchemaClass {

  
  public ref ParticleReplicationMode_t ReplicationMode { get; }
  
  public ref bool ScaleChildParticleRadii { get; }
  
  public IParticleCollectionFloatInput MinRandomRadiusScale { get; }
  
  public IParticleCollectionFloatInput MaxRandomRadiusScale { get; }
  
  public IParticleCollectionVecInput MinRandomDisplacement { get; }
  
  public IParticleCollectionVecInput MaxRandomDisplacement { get; }
  
  public IParticleCollectionFloatInput ModellingScale { get; }
}