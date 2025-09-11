using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISmokeGrenadeProjectile : IBaseCSGrenadeProjectile {

  
  public ref int SmokeEffectTickBegin { get; }
  
  public ref bool DidSmokeEffect { get; }
  
  public ref int RandomSeed { get; }
  
  public ref Vector SmokeColor { get; }
  
  public ref Vector SmokeDetonationPos { get; }
  
  public ref CUtlVector<byte> VoxelFrameData { get; }
  
  public ref int VoxelFrameDataSize { get; }
  
  public ref int VoxelUpdate { get; }
  
  public IGameTime_t LastBounce { get; }
  
  public IGameTime_t FllastSimulationTime { get; }
  
  public ref bool ExplodeFromInferno { get; }
  
  public ref bool DidGroundScorch { get; }
}