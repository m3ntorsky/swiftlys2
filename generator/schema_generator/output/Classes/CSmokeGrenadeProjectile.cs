using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSmokeGrenadeProjectile : CBaseCSGrenadeProjectile, ISmokeGrenadeProjectile {

  public CSmokeGrenadeProjectile(nint handle) : base(handle) {
  }

  public IGameTime_t LastBounce {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xE31DC1B8A4A556A7));
  }
  public IGameTime_t FllastSimulationTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xE31DC1B8F56D1EED));
  }
  public ref bool ExplodeFromInferno {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE31DC1B879437D79));
  }
  public ref bool DidGroundScorch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE31DC1B80AD64DF5));
  }

  public void SmokeEffectTickBeginUpdated() {
    Schema.Update(_Handle, 0xE31DC1B8F5A25253);
  }
  public void DidSmokeEffectUpdated() {
    Schema.Update(_Handle, 0xE31DC1B881A8B092);
  }
  public void RandomSeedUpdated() {
    Schema.Update(_Handle, 0xE31DC1B86388F067);
  }
  public void SmokeColorUpdated() {
    Schema.Update(_Handle, 0xE31DC1B87808EA9D);
  }
  public void SmokeDetonationPosUpdated() {
    Schema.Update(_Handle, 0xE31DC1B8743595D7);
  }
  public void VoxelFrameDataUpdated() {
    Schema.Update(_Handle, 0xE31DC1B8E854C6C4);
  }
  public void VoxelFrameDataSizeUpdated() {
    Schema.Update(_Handle, 0xE31DC1B8369FBFD9);
  }
  public void VoxelUpdateUpdated() {
    Schema.Update(_Handle, 0xE31DC1B8EE30DA3A);
  }
}