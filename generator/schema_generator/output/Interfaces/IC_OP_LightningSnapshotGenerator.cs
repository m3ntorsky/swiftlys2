using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LightningSnapshotGenerator : IParticleFunctionPreEmission {

  
  public ref int CPSnapshot { get; }
  
  public ref int CPStartPnt { get; }
  
  public ref int CPEndPnt { get; }
  
  public IParticleCollectionFloatInput Segments { get; }
  
  public IParticleCollectionFloatInput Offset { get; }
  
  public IParticleCollectionFloatInput OffsetDecay { get; }
  
  public IParticleCollectionFloatInput RecalcRate { get; }
  
  public IParticleCollectionFloatInput UVScale { get; }
  
  public IParticleCollectionFloatInput UVOffset { get; }
  
  public IParticleCollectionFloatInput SplitRate { get; }
  
  public IParticleCollectionFloatInput BranchTwist { get; }
  
  public ref ParticleLightnintBranchBehavior_t BranchBehavior { get; }
  
  public IParticleCollectionFloatInput RadiusStart { get; }
  
  public IParticleCollectionFloatInput RadiusEnd { get; }
  
  public IParticleCollectionFloatInput DedicatedPool { get; }
}