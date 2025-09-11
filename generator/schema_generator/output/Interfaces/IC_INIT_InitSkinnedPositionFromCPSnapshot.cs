using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitSkinnedPositionFromCPSnapshot : IParticleFunctionInitializer {

  
  public ref int SnapshotControlPointNumber { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool Random { get; }
  
  public ref int RandomSeed { get; }
  
  public ref bool Rigid { get; }
  
  public ref bool SetNormal { get; }
  
  public ref bool IgnoreDt { get; }
  
  public ref float MinNormalVelocity { get; }
  
  public ref float MaxNormalVelocity { get; }
  
  public ref SnapshotIndexType_t IndexType { get; }
  
  public IPerParticleFloatInput ReadIndex { get; }
  
  public ref float Increment { get; }
  
  public ref int FullLoopIncrement { get; }
  
  public ref int SnapShotStartPoint { get; }
  
  public ref float BoneVelocity { get; }
  
  public ref float BoneVelocityMax { get; }
  
  public ref bool CopyColor { get; }
  
  public ref bool CopyAlpha { get; }
  
  public ref bool SetRadius { get; }
}