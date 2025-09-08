using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointCamera : CBaseEntity, IPointCamera {

  public CPointCamera(nint handle) : base(handle) {
  }

  public ref float TargetFOV {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3E5CC0835BA7ABEB));
  }
  public ref float DegreesPerSecond {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3E5CC083469C1605));
  }
  public ref bool IsOn {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3E5CC0836387DB60));
  }
  public IPointCamera Next {
    get => new CPointCamera(_Handle + Schema.GetOffset(0x3E5CC08332B11E0E));
  }

  public void FOVUpdated() {
    Schema.Update(_Handle, 0x3E5CC0835C3A63DC);
  }
  public void ResolutionUpdated() {
    Schema.Update(_Handle, 0x3E5CC083B9351D0F);
  }
  public void FogEnableUpdated() {
    Schema.Update(_Handle, 0x3E5CC0837ED6A448);
  }
  public void FogColorUpdated() {
    Schema.Update(_Handle, 0x3E5CC083C5585AAE);
  }
  public void FogStartUpdated() {
    Schema.Update(_Handle, 0x3E5CC0832A8DE023);
  }
  public void FogEndUpdated() {
    Schema.Update(_Handle, 0x3E5CC08334D4BC16);
  }
  public void FogMaxDensityUpdated() {
    Schema.Update(_Handle, 0x3E5CC08343CD4C8B);
  }
  public void ActiveUpdated() {
    Schema.Update(_Handle, 0x3E5CC0838334208F);
  }
  public void UseScreenAspectRatioUpdated() {
    Schema.Update(_Handle, 0x3E5CC08353101AA3);
  }
  public void AspectRatioUpdated() {
    Schema.Update(_Handle, 0x3E5CC08381C7922E);
  }
  public void NoSkyUpdated() {
    Schema.Update(_Handle, 0x3E5CC083760FF03B);
  }
  public void BrightnessUpdated() {
    Schema.Update(_Handle, 0x3E5CC0832E2B25BE);
  }
  public void ZFarUpdated() {
    Schema.Update(_Handle, 0x3E5CC083578834A4);
  }
  public void ZNearUpdated() {
    Schema.Update(_Handle, 0x3E5CC083C81DED31);
  }
  public void CanHLTVUseUpdated() {
    Schema.Update(_Handle, 0x3E5CC083EF15745A);
  }
  public void AlignWithParentUpdated() {
    Schema.Update(_Handle, 0x3E5CC08371E0F322);
  }
  public void DofEnabledUpdated() {
    Schema.Update(_Handle, 0x3E5CC083EDC8F923);
  }
  public void DofNearBlurryUpdated() {
    Schema.Update(_Handle, 0x3E5CC0837C69D002);
  }
  public void DofNearCrispUpdated() {
    Schema.Update(_Handle, 0x3E5CC083B0E97BC1);
  }
  public void DofFarCrispUpdated() {
    Schema.Update(_Handle, 0x3E5CC0832EC98B88);
  }
  public void DofFarBlurryUpdated() {
    Schema.Update(_Handle, 0x3E5CC083312C6605);
  }
  public void DofTiltToGroundUpdated() {
    Schema.Update(_Handle, 0x3E5CC0833DF50E81);
  }
}