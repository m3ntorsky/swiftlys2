using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseButton : CBaseToggle, IBaseButton {

  public CBaseButton(nint handle) : base(handle) {
  }

  public CBaseButton(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref QAngle MoveEntitySpace {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1911FA7F325319F9));
  }
  public ref bool StayPushed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1911FA7FF5E81349));
  }
  public ref bool Rotating {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1911FA7F6DAD9199));
  }
  public Ilocksound_t Ls {
    get => new locksound_t(_Handle + Schema.GetOffset(0x1911FA7FD3B05E88));
  }
  public ref CUtlSymbolLarge UseSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1911FA7FCCC8AC24));
  }
  public ref CUtlSymbolLarge LockedSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1911FA7FB3FCB84B));
  }
  public ref CUtlSymbolLarge UnlockedSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1911FA7FDC697A96));
  }
  public ref CUtlSymbolLarge OverrideAnticipationName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1911FA7FDBCCC724));
  }
  public ref bool Locked {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1911FA7FD08E97F3));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1911FA7F3A7C5965));
  }
  public IGameTime_t UseLockedTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1911FA7FE94A05A1));
  }
  public ref bool SolidBsp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1911FA7FA50CEC89));
  }
  public IEntityIOOutput OnDamaged {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1911FA7F1667F41F));
  }
  public IEntityIOOutput OnPressed {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1911FA7F6707E726));
  }
  public IEntityIOOutput OnUseLocked {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1911FA7FE603388D));
  }
  public IEntityIOOutput OnIn {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1911FA7FE9F7186F));
  }
  public IEntityIOOutput OnOut {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1911FA7FF28E1D54));
  }
  public ref int State {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1911FA7F7C824322));
  }
  public ref CEntityHandle Constraint {
    get => ref _Handle.AsRef<CEntityHandle>(Schema.GetOffset(0x1911FA7F16F916EC));
  }
  public ref CEntityHandle ConstraintParent {
    get => ref _Handle.AsRef<CEntityHandle>(Schema.GetOffset(0x1911FA7F0E2D0AA4));
  }
  public ref bool ForceNpcExclude {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1911FA7F4194963F));
  }
  public ref CUtlSymbolLarge GlowEntity {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1911FA7F8B25D228));
  }
  public ref CHandle< CBaseModelEntity > GlowEntity {
    get => ref _Handle.AsRef<CHandle< CBaseModelEntity >>(Schema.GetOffset(0x1911FA7F35C883E7));
  }
  public ref bool Usable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1911FA7F44B8E369));
  }
  public ref CUtlSymbolLarge DisplayText {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1911FA7FDE5320C5));
  }

  public void GlowEntityUpdated() {
    Schema.Update(_Handle, 0x1911FA7F35C883E7);
  }
  public void UsableUpdated() {
    Schema.Update(_Handle, 0x1911FA7F44B8E369);
  }
  public void DisplayTextUpdated() {
    Schema.Update(_Handle, 0x1911FA7FDE5320C5);
  }
}