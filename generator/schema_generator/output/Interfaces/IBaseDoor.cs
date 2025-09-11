using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseDoor : IBaseToggle {

  
  public ref QAngle MoveEntitySpace { get; }
  
  public ref Vector MoveDirParentSpace { get; }
  
  public Ilocksound_t Ls { get; }
  
  public ref bool ForceClosed { get; }
  
  public ref bool DoorGroup { get; }
  
  public ref bool Locked { get; }
  
  public ref bool IgnoreDebris { get; }
  
  public ref bool NoNPCs { get; }
  
  public ref FuncDoorSpawnPos_t SpawnPosition { get; }
  
  public ref float BlockDamage { get; }
  
  public ref CUtlSymbolLarge NoiseMoving { get; }
  
  public ref CUtlSymbolLarge NoiseArrived { get; }
  
  public ref CUtlSymbolLarge NoiseMovingClosed { get; }
  
  public ref CUtlSymbolLarge NoiseArrivedClosed { get; }
  
  public ref CUtlSymbolLarge ChainTarget { get; }
  
  public IEntityIOOutput OnBlockedClosing { get; }
  
  public IEntityIOOutput OnBlockedOpening { get; }
  
  public IEntityIOOutput OnUnblockedClosing { get; }
  
  public IEntityIOOutput OnUnblockedOpening { get; }
  
  public IEntityIOOutput OnFullyClosed { get; }
  
  public IEntityIOOutput OnFullyOpen { get; }
  
  public IEntityIOOutput OnClose { get; }
  
  public IEntityIOOutput OnOpen { get; }
  
  public IEntityIOOutput OnLockedUse { get; }
  
  public ref bool LoopMoveSound { get; }
  
  public ref bool CreateNavObstacle { get; }
  
  public ref bool IsChaining { get; }
  
  public ref bool IsUsable { get; }
}