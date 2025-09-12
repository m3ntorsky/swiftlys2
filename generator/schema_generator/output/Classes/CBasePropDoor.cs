using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBasePropDoor : CDynamicProp, IBasePropDoor {

  public CBasePropDoor(nint handle) : base(handle) {
  }

  public ref float AutoReturnDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x140EA8BE772B0615));
  }
  public ref CUtlVector<CHandle<CBasePropDoor>> DoorList {
    get => ref _Handle.AsRef<CUtlVector<CHandle<CBasePropDoor>>>(Schema.GetOffset(0x140EA8BE1E34E0D7));
  }
  public ref int HardwareType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x140EA8BEAA155C65));
  }
  public ref bool NeedsHardware {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x140EA8BE4748BCCE));
  }
  public ref CHandle<CBaseEntity> Blocker {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x140EA8BE21787A5F));
  }
  public ref bool FirstBlocked {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x140EA8BEF120E737));
  }
  public Ilocksound_t Ls {
    get => new locksound_t(_Handle + Schema.GetOffset(0x140EA8BED3B05E88));
  }
  public ref bool ForceClosed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x140EA8BE397D7E34));
  }
  public ref Vector LatchWorldPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x140EA8BEEBC4A818));
  }
  public ref CHandle<CBaseEntity> Activator {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x140EA8BEAB093BB2));
  }
  public ISchemaUntypedField SoundMoving {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BE096B0232));
  }
  public ISchemaUntypedField SoundOpen {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BE736F2FD4));
  }
  public ISchemaUntypedField SoundClose {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BE25C06648));
  }
  public ISchemaUntypedField SoundLock {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BE79ED369B));
  }
  public ISchemaUntypedField SoundUnlock {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BE784A9850));
  }
  public ISchemaUntypedField SoundLatch {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BE1128D286));
  }
  public ISchemaUntypedField SoundPound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BE100E3D8E));
  }
  public ISchemaUntypedField SoundJiggle {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BEA6C5140C));
  }
  public ISchemaUntypedField SoundLockedAnim {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BEF4D24043));
  }
  public ref int NumCloseAttempts {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x140EA8BEEE2FAC03));
  }
  public ref CUtlStringToken PhysicsMaterial {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x140EA8BEF6A7286B));
  }
  public ISchemaUntypedField SlaveName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x140EA8BEAA484A63));
  }
  public IEntityIOOutput OnBlockedClosing {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BEEC8BC45F));
  }
  public IEntityIOOutput OnBlockedOpening {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BEF0BA7AA8));
  }
  public IEntityIOOutput OnUnblockedClosing {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BEB150C15C));
  }
  public IEntityIOOutput OnUnblockedOpening {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BE1AC8E62F));
  }
  public IEntityIOOutput OnFullyClosed {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BE75470294));
  }
  public IEntityIOOutput OnFullyOpen {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BE21733AE4));
  }
  public IEntityIOOutput OnClose {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BEBE036874));
  }
  public IEntityIOOutput OnOpen {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BE109A2278));
  }
  public IEntityIOOutput OnLockedUse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BEFD62B6A1));
  }
  public IEntityIOOutput OnAjarOpen {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x140EA8BE70F36224));
  }

  public void DoorStateUpdated() {
    Schema.Update(_Handle, 0x140EA8BE55D06645);
  }
  public void LockedUpdated() {
    Schema.Update(_Handle, 0x140EA8BED08E97F3);
  }
  public void NoNPCsUpdated() {
    Schema.Update(_Handle, 0x140EA8BE237405C2);
  }
  public void ClosedPositionUpdated() {
    Schema.Update(_Handle, 0x140EA8BEC93C638A);
  }
  public void ClosedAnglesUpdated() {
    Schema.Update(_Handle, 0x140EA8BE53D26DF1);
  }
  public void MasterUpdated() {
    Schema.Update(_Handle, 0x140EA8BEB8DA1B0D);
  }
}