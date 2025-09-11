using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MaintainEmitter : IParticleFunctionEmitter {

  
  public IParticleCollectionFloatInput ParticlesToMaintain { get; }
  
  public ref float StartTime { get; }
  
  public IParticleCollectionFloatInput EmissionDuration { get; }
  
  public ref float EmissionRate { get; }
  
  public ref int SnapshotControlPoint { get; }
  
  public ref CUtlString StrSnapshotSubset { get; }
  
  public ref bool EmitInstantaneously { get; }
  
  public ref bool FinalEmitOnStop { get; }
  
  public IParticleCollectionFloatInput Scale { get; }
}