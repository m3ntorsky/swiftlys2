using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseDoor : CBaseToggle, IBaseDoor {

  public CBaseDoor(nint handle) : base(handle) {
  }

  public CBaseDoor(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref QAngle MoveEntitySpace {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x798B70E7325319F9));
  }
  public ref Vector MoveDirParentSpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x798B70E7EC2120EF));
  }
  public Ilocksound_t Ls {
    get => new locksound_t(_Handle + Schema.GetOffset(0x798B70E7D3B05E88));
  }
  public ref bool ForceClosed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E7397D7E34));
  }
  public ref bool DoorGroup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E7391E1820));
  }
  public ref bool Locked {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E7D08E97F3));
  }
  public ref bool IgnoreDebris {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E7A67DDAD4));
  }
  public ref bool NoNPCs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E7237405C2));
  }
  public ref FuncDoorSpawnPos_t SpawnPosition {
    get => ref _Handle.AsRef<FuncDoorSpawnPos_t>(Schema.GetOffset(0x798B70E7F5AD878C));
  }
  public ref float BlockDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x798B70E7A5348091));
  }
  public ref CUtlSymbolLarge NoiseMoving {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x798B70E7415AB84B));
  }
  public ref CUtlSymbolLarge NoiseArrived {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x798B70E7D2CDE47A));
  }
  public ref CUtlSymbolLarge NoiseMovingClosed {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x798B70E7ED56FC0F));
  }
  public ref CUtlSymbolLarge NoiseArrivedClosed {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x798B70E78637F9A6));
  }
  public ref CUtlSymbolLarge ChainTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x798B70E762B5A227));
  }
  public IEntityIOOutput OnBlockedClosing {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E7EC8BC45F));
  }
  public IEntityIOOutput OnBlockedOpening {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E7F0BA7AA8));
  }
  public IEntityIOOutput OnUnblockedClosing {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E7B150C15C));
  }
  public IEntityIOOutput OnUnblockedOpening {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E71AC8E62F));
  }
  public IEntityIOOutput OnFullyClosed {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E775470294));
  }
  public IEntityIOOutput OnFullyOpen {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E721733AE4));
  }
  public IEntityIOOutput OnClose {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E7BE036874));
  }
  public IEntityIOOutput OnOpen {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E7109A2278));
  }
  public IEntityIOOutput OnLockedUse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x798B70E7FD62B6A1));
  }
  public ref bool LoopMoveSound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E7A274AA19));
  }
  public ref bool CreateNavObstacle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E71849970B));
  }
  public ref bool IsChaining {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E7A186D5CA));
  }
  public ref bool IsUsable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x798B70E799E20219));
  }

  public void IsUsableUpdated() {
    Schema.Update(_Handle, 0x798B70E799E20219);
  }
}