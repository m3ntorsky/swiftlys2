using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvWindController : CBaseEntity, IEnvWindController {

  public CEnvWindController(nint handle) : base(handle) {
  }

  public CEnvWindController(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEnvWindShared EnvWindShared {
    get => new CEnvWindShared(_Handle + Schema.GetOffset(0x85B1A0AB75DDCB0F));
  }
  public ref float DirectionVariation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85B1A0AB72560E57));
  }
  public ref float SpeedVariation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85B1A0AB19844531));
  }
  public ref float Turbulence {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85B1A0AB8E2CE730));
  }
  public ref float VolumeHalfExtentXY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85B1A0AB2445F06D));
  }
  public ref float VolumeHalfExtentZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85B1A0AB9BA18280));
  }
  public ref int VolumeResolutionXY {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x85B1A0AB97B5AB36));
  }
  public ref int VolumeResolutionZ {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x85B1A0ABA1610511));
  }
  public ref int ClipmapLevels {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x85B1A0AB5B9AA8D4));
  }
  public ref bool IsMaster {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x85B1A0ABDE5719A3));
  }
  public ref bool FirstTime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x85B1A0ABD23C3138));
  }

  public void EnvWindSharedUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB75DDCB0F);
  }
  public void DirectionVariationUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB72560E57);
  }
  public void SpeedVariationUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB19844531);
  }
  public void TurbulenceUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB8E2CE730);
  }
  public void VolumeHalfExtentXYUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB2445F06D);
  }
  public void VolumeHalfExtentZUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB9BA18280);
  }
  public void VolumeResolutionXYUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB97B5AB36);
  }
  public void VolumeResolutionZUpdated() {
    Schema.Update(_Handle, 0x85B1A0ABA1610511);
  }
  public void ClipmapLevelsUpdated() {
    Schema.Update(_Handle, 0x85B1A0AB5B9AA8D4);
  }
  public void IsMasterUpdated() {
    Schema.Update(_Handle, 0x85B1A0ABDE5719A3);
  }
}