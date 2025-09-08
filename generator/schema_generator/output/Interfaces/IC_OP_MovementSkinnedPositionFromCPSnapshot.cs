using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MovementSkinnedPositionFromCPSnapshot : IParticleFunctionOperator {

  public ref int SnapshotControlPointNumber { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool Random { get; }
  
  public ref int RandomSeed { get; }
  
  public ref bool SetNormal { get; }
  
  public ref bool SetRadius { get; }
  
  public ref SnapshotIndexType_t IndexType { get; }
  
  public IPerParticleFloatInput ReadIndex { get; }
  
  public IParticleCollectionFloatInput Increment { get; }
  
  public IParticleCollectionFloatInput FullLoopIncrement { get; }
  
  public IParticleCollectionFloatInput SnapShotStartPoint { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
}