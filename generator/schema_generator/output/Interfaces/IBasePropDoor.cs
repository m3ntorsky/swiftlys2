using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBasePropDoor : IDynamicProp {

  public ref float AutoReturnDelay { get; }
  
  public ref CUtlVector DoorList { get; }
  
  public ref int HardwareType { get; }
  
  public ref bool NeedsHardware { get; }
  
  public ref DoorState_t DoorState { get; }
  
  public ref bool Locked { get; }
  
  public ref bool NoNPCs { get; }
  
  public ref Vector ClosedPosition { get; }
  
  public ref QAngle ClosedAngles { get; }
  
  public CHandle<IBaseEntity> Blocker { get; }
  
  public ref bool FirstBlocked { get; }
  
  public Ilocksound_t Ls { get; }
  
  public ref bool ForceClosed { get; }
  
  public ref Vector LatchWorldPosition { get; }
  
  public CHandle<IBaseEntity> Activator { get; }
  
  public ref CUtlSymbolLarge SoundMoving { get; }
  
  public ref CUtlSymbolLarge SoundOpen { get; }
  
  public ref CUtlSymbolLarge SoundClose { get; }
  
  public ref CUtlSymbolLarge SoundLock { get; }
  
  public ref CUtlSymbolLarge SoundUnlock { get; }
  
  public ref CUtlSymbolLarge SoundLatch { get; }
  
  public ref CUtlSymbolLarge SoundPound { get; }
  
  public ref CUtlSymbolLarge SoundJiggle { get; }
  
  public ref CUtlSymbolLarge SoundLockedAnim { get; }
  
  public ref int NumCloseAttempts { get; }
  
  public ref CUtlStringToken PhysicsMaterial { get; }
  
  public ref CUtlSymbolLarge SlaveName { get; }
  
  public CHandle<IBasePropDoor> Master { get; }
  
  public IEntityIOOutput OnBlockedClosing { get; }
  
  public IEntityIOOutput OnBlockedOpening { get; }
  
  public IEntityIOOutput OnUnblockedClosing { get; }
  
  public IEntityIOOutput OnUnblockedOpening { get; }
  
  public IEntityIOOutput OnFullyClosed { get; }
  
  public IEntityIOOutput OnFullyOpen { get; }
  
  public IEntityIOOutput OnClose { get; }
  
  public IEntityIOOutput OnOpen { get; }
  
  public IEntityIOOutput OnLockedUse { get; }
  
  public IEntityIOOutput OnAjarOpen { get; }
  
}