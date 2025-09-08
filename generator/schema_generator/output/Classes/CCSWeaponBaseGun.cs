using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSWeaponBaseGun : CCSWeaponBase, ICSWeaponBaseGun {

  public CCSWeaponBaseGun(nint handle) : base(handle) {
  }

  public ref int SilencedModelIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBC30B08178E5CAAB));
  }
  public ref bool InPrecache {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC30B081495003CB));
  }
  public ref bool SkillReloadAvailable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC30B081C7961BE2));
  }
  public ref bool SkillReloadLiftedReloadKey {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC30B0819C3A15B5));
  }
  public ref bool SkillBoltInterruptAvailable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC30B0816FE62EEF));
  }
  public ref bool SkillBoltLiftedFireKey {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC30B081AB7AEB7C));
  }

  public void ZoomLevelUpdated() {
    Schema.Update(_Handle, 0xBC30B081444E63A0);
  }
  public void BurstShotsRemainingUpdated() {
    Schema.Update(_Handle, 0xBC30B081F53841A5);
  }
  public void NeedsBoltActionUpdated() {
    Schema.Update(_Handle, 0xBC30B0813632E797);
  }
  public void RevolverCylinderIdxUpdated() {
    Schema.Update(_Handle, 0xBC30B08119D0E90B);
  }
}