using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvVolumetricFogController : CBaseEntity, IEnvVolumetricFogController {

  public CEnvVolumetricFogController(nint handle) : base(handle) {
  }

  public ref bool FirstTime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2A8A520FD23C3138));
  }

  public void ScatteringUpdated() {
    Schema.Update(_Handle, 0x2A8A520FE243F9E5);
  }
  public void TintColorUpdated() {
    Schema.Update(_Handle, 0x2A8A520FAF2613F3);
  }
  public void AnisotropyUpdated() {
    Schema.Update(_Handle, 0x2A8A520FE7F1A723);
  }
  public void FadeSpeedUpdated() {
    Schema.Update(_Handle, 0x2A8A520FC041A38C);
  }
  public void DrawDistanceUpdated() {
    Schema.Update(_Handle, 0x2A8A520F57522D4A);
  }
  public void FadeInStartUpdated() {
    Schema.Update(_Handle, 0x2A8A520FF5AD2D6A);
  }
  public void FadeInEndUpdated() {
    Schema.Update(_Handle, 0x2A8A520FE2C847BF);
  }
  public void IndirectStrengthUpdated() {
    Schema.Update(_Handle, 0x2A8A520F559AA198);
  }
  public void VolumeDepthUpdated() {
    Schema.Update(_Handle, 0x2A8A520F2276C184);
  }
  public void FirstVolumeSliceThicknessUpdated() {
    Schema.Update(_Handle, 0x2A8A520FCB8BF49F);
  }
  public void IndirectTextureDimXUpdated() {
    Schema.Update(_Handle, 0x2A8A520F885076D4);
  }
  public void IndirectTextureDimYUpdated() {
    Schema.Update(_Handle, 0x2A8A520F89507867);
  }
  public void IndirectTextureDimZUpdated() {
    Schema.Update(_Handle, 0x2A8A520F8A5079FA);
  }
  public void BoxMinsUpdated() {
    Schema.Update(_Handle, 0x2A8A520FD8201373);
  }
  public void BoxMaxsUpdated() {
    Schema.Update(_Handle, 0x2A8A520F817A3B31);
  }
  public void ActiveUpdated() {
    Schema.Update(_Handle, 0x2A8A520F8334208F);
  }
  public void StartAnisoTimeUpdated() {
    Schema.Update(_Handle, 0x2A8A520F84853AEE);
  }
  public void StartScatterTimeUpdated() {
    Schema.Update(_Handle, 0x2A8A520F550791B8);
  }
  public void StartDrawDistanceTimeUpdated() {
    Schema.Update(_Handle, 0x2A8A520F0108704D);
  }
  public void StartAnisotropyUpdated() {
    Schema.Update(_Handle, 0x2A8A520FCFF4A7DD);
  }
  public void StartScatteringUpdated() {
    Schema.Update(_Handle, 0x2A8A520F134FA97F);
  }
  public void StartDrawDistanceUpdated() {
    Schema.Update(_Handle, 0x2A8A520FCF179D0C);
  }
  public void DefaultAnisotropyUpdated() {
    Schema.Update(_Handle, 0x2A8A520FB9484338);
  }
  public void DefaultScatteringUpdated() {
    Schema.Update(_Handle, 0x2A8A520F3F2D053A);
  }
  public void DefaultDrawDistanceUpdated() {
    Schema.Update(_Handle, 0x2A8A520FCCADC381);
  }
  public void StartDisabledUpdated() {
    Schema.Update(_Handle, 0x2A8A520F61ED0C4F);
  }
  public void EnableIndirectUpdated() {
    Schema.Update(_Handle, 0x2A8A520FD9682660);
  }
  public void IsMasterUpdated() {
    Schema.Update(_Handle, 0x2A8A520FDE5719A3);
  }
  public void FogIndirectTextureUpdated() {
    Schema.Update(_Handle, 0x2A8A520FD42D635A);
  }
  public void ForceRefreshCountUpdated() {
    Schema.Update(_Handle, 0x2A8A520F77E98C4A);
  }
  public void NoiseSpeedUpdated() {
    Schema.Update(_Handle, 0x2A8A520F5C5BB620);
  }
  public void NoiseStrengthUpdated() {
    Schema.Update(_Handle, 0x2A8A520F556ED5D0);
  }
  public void NoiseScaleUpdated() {
    Schema.Update(_Handle, 0x2A8A520F420F9B01);
  }
  public void WindSpeedUpdated() {
    Schema.Update(_Handle, 0x2A8A520F37AADB3E);
  }
  public void WindDirectionUpdated() {
    Schema.Update(_Handle, 0x2A8A520FED0F7D3C);
  }
}