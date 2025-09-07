using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class fogparams_t : SchemaClass, Ifogparams_t {

  public fogparams_t(nint handle) : base(handle) {
  }

  public fogparams_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector DirPrimary {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xCE352DA69D025A12));
  }
  public ref Color ColorPrimary {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xCE352DA6B7CCC646));
  }
  public ref Color ColorSecondary {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xCE352DA69E5EDE5A));
  }
  public ref Color ColorPrimaryLerpTo {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xCE352DA6702FBD96));
  }
  public ref Color ColorSecondaryLerpTo {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xCE352DA627E54D7A));
  }
  public ref float Start {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6652B04DF));
  }
  public ref float End {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA66A8E75AA));
  }
  public ref float Farz {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA60E9043FC));
  }
  public ref float Maxdensity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6C8F29F97));
  }
  public ref float Exponent {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA632F1D446));
  }
  public ref float HDRColorScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6E4EAF0DE));
  }
  public ref float SkyboxFogFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6A7ADD816));
  }
  public ref float SkyboxFogFactorLerpTo {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6F366AC46));
  }
  public ref float StartLerpTo {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6FF7E14AB));
  }
  public ref float EndLerpTo {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6AB5FC36A));
  }
  public ref float MaxdensityLerpTo {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6B2204BA3));
  }
  public IGameTime_t Lerptime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xCE352DA6F1157821));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA62FA0FD0D));
  }
  public ref float Blendtobackground {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA617A07511));
  }
  public ref float Scattering {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6A6DF1F9F));
  }
  public ref float Locallightscale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE352DA6D520D236));
  }
  public ref bool Enable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCE352DA6AF8BB8CE));
  }
  public ref bool Blend {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCE352DA60BBC40D8));
  }
  public ref bool Padding2 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCE352DA6BC87772C));
  }
  public ref bool Padding {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCE352DA6DC7CD796));
  }

  public void DirPrimaryUpdated() {
    Schema.Update(_Handle, 0xCE352DA69D025A12);
  }
  public void ColorPrimaryUpdated() {
    Schema.Update(_Handle, 0xCE352DA6B7CCC646);
  }
  public void ColorSecondaryUpdated() {
    Schema.Update(_Handle, 0xCE352DA69E5EDE5A);
  }
  public void ColorPrimaryLerpToUpdated() {
    Schema.Update(_Handle, 0xCE352DA6702FBD96);
  }
  public void ColorSecondaryLerpToUpdated() {
    Schema.Update(_Handle, 0xCE352DA627E54D7A);
  }
  public void StartUpdated() {
    Schema.Update(_Handle, 0xCE352DA6652B04DF);
  }
  public void EndUpdated() {
    Schema.Update(_Handle, 0xCE352DA66A8E75AA);
  }
  public void FarzUpdated() {
    Schema.Update(_Handle, 0xCE352DA60E9043FC);
  }
  public void MaxdensityUpdated() {
    Schema.Update(_Handle, 0xCE352DA6C8F29F97);
  }
  public void ExponentUpdated() {
    Schema.Update(_Handle, 0xCE352DA632F1D446);
  }
  public void HDRColorScaleUpdated() {
    Schema.Update(_Handle, 0xCE352DA6E4EAF0DE);
  }
  public void SkyboxFogFactorUpdated() {
    Schema.Update(_Handle, 0xCE352DA6A7ADD816);
  }
  public void SkyboxFogFactorLerpToUpdated() {
    Schema.Update(_Handle, 0xCE352DA6F366AC46);
  }
  public void StartLerpToUpdated() {
    Schema.Update(_Handle, 0xCE352DA6FF7E14AB);
  }
  public void EndLerpToUpdated() {
    Schema.Update(_Handle, 0xCE352DA6AB5FC36A);
  }
  public void MaxdensityLerpToUpdated() {
    Schema.Update(_Handle, 0xCE352DA6B2204BA3);
  }
  public void LerptimeUpdated() {
    Schema.Update(_Handle, 0xCE352DA6F1157821);
  }
  public void DurationUpdated() {
    Schema.Update(_Handle, 0xCE352DA62FA0FD0D);
  }
  public void BlendtobackgroundUpdated() {
    Schema.Update(_Handle, 0xCE352DA617A07511);
  }
  public void ScatteringUpdated() {
    Schema.Update(_Handle, 0xCE352DA6A6DF1F9F);
  }
  public void LocallightscaleUpdated() {
    Schema.Update(_Handle, 0xCE352DA6D520D236);
  }
  public void EnableUpdated() {
    Schema.Update(_Handle, 0xCE352DA6AF8BB8CE);
  }
  public void BlendUpdated() {
    Schema.Update(_Handle, 0xCE352DA60BBC40D8);
  }
}