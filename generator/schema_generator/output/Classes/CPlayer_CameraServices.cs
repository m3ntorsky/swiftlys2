using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_CameraServices : CPlayerPawnComponent, IPlayer_CameraServices {

  public CPlayer_CameraServices(nint handle) : base(handle) {
  }

  public ref float OldPlayerZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCF107677A9E373D));
  }
  public ref float OldPlayerViewOffsetZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCF10767CA126E73));
  }
  public ref CUtlVector TriggerSoundscapeList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xCF10767F74D6272));
  }

  public void CsViewPunchAngleUpdated() {
    Schema.Update(_Handle, 0xCF1076771108E39);
  }
  public void CsViewPunchAngleTickUpdated() {
    Schema.Update(_Handle, 0xCF10767832A08EC);
  }
  public void CsViewPunchAngleTickRatioUpdated() {
    Schema.Update(_Handle, 0xCF1076709BF7629);
  }
  public void PlayerFogUpdated() {
    Schema.Update(_Handle, 0xCF1076781FBA280);
  }
  public void ColorCorrectionCtrlUpdated() {
    Schema.Update(_Handle, 0xCF1076724DC833B);
  }
  public void ViewEntityUpdated() {
    Schema.Update(_Handle, 0xCF107677FD940D1);
  }
  public void TonemapControllerUpdated() {
    Schema.Update(_Handle, 0xCF10767F5E1A34F);
  }
  public void AudioUpdated() {
    Schema.Update(_Handle, 0xCF1076722E8C9B9);
  }
  public void PostProcessingVolumesUpdated() {
    Schema.Update(_Handle, 0xCF107674BEE60DF);
  }
}