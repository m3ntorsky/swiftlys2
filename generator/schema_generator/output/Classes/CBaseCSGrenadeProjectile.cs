using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseCSGrenadeProjectile : CBaseGrenade, IBaseCSGrenadeProjectile {

  public CBaseCSGrenadeProjectile(nint handle) : base(handle) {
  }

  public IGameTime_t SpawnTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xC09C67029596A16B));
  }
  public ref byte OGSExtraFlags {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xC09C670221F95684));
  }
  public ref bool DetonationRecorded {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC09C67024164A13C));
  }
  public ref ushort ItemIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xC09C67025D8A6E7E));
  }
  public ref Vector OriginalSpawnLocation {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC09C67025E59F382));
  }
  public IGameTime_t LastBounceSoundTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xC09C670206AF4AB7));
  }
  public ISchemaUntypedField GrenadeSpin {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC09C67025A836591));
  }
  public ref Vector LastHitSurfaceNormal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC09C6702FAEF57FA));
  }
  public ref int TicksAtZeroVelocity {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC09C6702A4946C6D));
  }
  public ref bool HasEverHitEnemy {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC09C670259285A50));
  }

  public void InitialPositionUpdated() {
    Schema.Update(_Handle, 0xC09C67027E9CA9C4);
  }
  public void InitialVelocityUpdated() {
    Schema.Update(_Handle, 0xC09C67027C20BD90);
  }
  public void BouncesUpdated() {
    Schema.Update(_Handle, 0xC09C67026B81EBCE);
  }
  public void ExplodeEffectIndexUpdated() {
    Schema.Update(_Handle, 0xC09C6702178B5975);
  }
  public void ExplodeEffectTickBeginUpdated() {
    Schema.Update(_Handle, 0xC09C67022F04F603);
  }
  public void ExplodeEffectOriginUpdated() {
    Schema.Update(_Handle, 0xC09C6702AA7B4525);
  }
}