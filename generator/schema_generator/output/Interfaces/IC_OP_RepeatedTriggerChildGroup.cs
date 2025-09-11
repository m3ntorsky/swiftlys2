using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RepeatedTriggerChildGroup : IParticleFunctionPreEmission {

  
  public ref int ChildGroupID { get; }
  
  public IParticleCollectionFloatInput ClusterRefireTime { get; }
  
  public IParticleCollectionFloatInput ClusterSize { get; }
  
  public IParticleCollectionFloatInput ClusterCooldown { get; }
  
  public ref bool LimitChildCount { get; }
}