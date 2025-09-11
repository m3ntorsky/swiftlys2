using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DecayMaintainCount : IParticleFunctionOperator {

  
  public ref int ParticlesToMaintain { get; }
  
  public ref float DecayDelay { get; }
  
  public ref int SnapshotControlPoint { get; }
  
  public ref bool LifespanDecay { get; }
  
  public IParticleCollectionFloatInput Scale { get; }
  
  public ref bool KillNewest { get; }
}