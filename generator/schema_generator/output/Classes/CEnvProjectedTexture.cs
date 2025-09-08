using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvProjectedTexture : CModelPointEntity, IEnvProjectedTexture {

  public CEnvProjectedTexture(nint handle) : base(handle) {
  }



  public void TargetEntityUpdated() {
    Schema.Update(_Handle, 0x6813962E25D042A9);
  }
  public void StateUpdated() {
    Schema.Update(_Handle, 0x6813962E0CC206D6);
  }
  public void AlwaysUpdateUpdated() {
    Schema.Update(_Handle, 0x6813962EE25D9EE5);
  }
  public void LightFOVUpdated() {
    Schema.Update(_Handle, 0x6813962E70D592A0);
  }
  public void EnableShadowsUpdated() {
    Schema.Update(_Handle, 0x6813962E533A45E7);
  }
  public void SimpleProjectionUpdated() {
    Schema.Update(_Handle, 0x6813962E6493FA8A);
  }
  public void LightOnlyTargetUpdated() {
    Schema.Update(_Handle, 0x6813962EE27F7EA4);
  }
  public void LightWorldUpdated() {
    Schema.Update(_Handle, 0x6813962E47913E2D);
  }
  public void CameraSpaceUpdated() {
    Schema.Update(_Handle, 0x6813962E515DF218);
  }
  public void BrightnessScaleUpdated() {
    Schema.Update(_Handle, 0x6813962E5EFC3AAE);
  }
  public void LightColorUpdated() {
    Schema.Update(_Handle, 0x6813962E8411EB1E);
  }
  public void IntensityUpdated() {
    Schema.Update(_Handle, 0x6813962E67B5578C);
  }
  public void LinearAttenuationUpdated() {
    Schema.Update(_Handle, 0x6813962E6CA8542A);
  }
  public void QuadraticAttenuationUpdated() {
    Schema.Update(_Handle, 0x6813962E702DE3A9);
  }
  public void VolumetricUpdated() {
    Schema.Update(_Handle, 0x6813962E02438A79);
  }
  public void NoiseStrengthUpdated() {
    Schema.Update(_Handle, 0x6813962EC932831E);
  }
  public void FlashlightTimeUpdated() {
    Schema.Update(_Handle, 0x6813962E4D30A610);
  }
  public void NumPlanesUpdated() {
    Schema.Update(_Handle, 0x6813962E4615695C);
  }
  public void PlaneOffsetUpdated() {
    Schema.Update(_Handle, 0x6813962ED394676C);
  }
  public void VolumetricIntensityUpdated() {
    Schema.Update(_Handle, 0x6813962E97D0DF80);
  }
  public void ColorTransitionTimeUpdated() {
    Schema.Update(_Handle, 0x6813962E2E5E1AA4);
  }
  public void AmbientUpdated() {
    Schema.Update(_Handle, 0x6813962EB4F63429);
  }
  public void SpotlightTextureNameUpdated() {
    Schema.Update(_Handle, 0x6813962E907FC625);
  }
  public void SpotlightTextureFrameUpdated() {
    Schema.Update(_Handle, 0x6813962E749EAC03);
  }
  public void ShadowQualityUpdated() {
    Schema.Update(_Handle, 0x6813962E74420956);
  }
  public void NearZUpdated() {
    Schema.Update(_Handle, 0x6813962ECB91ABB1);
  }
  public void FarZUpdated() {
    Schema.Update(_Handle, 0x6813962E38F5E41A);
  }
  public void ProjectionSizeUpdated() {
    Schema.Update(_Handle, 0x6813962E6A001BA3);
  }
  public void RotationUpdated() {
    Schema.Update(_Handle, 0x6813962E523ECF71);
  }
  public void FlipHorizontalUpdated() {
    Schema.Update(_Handle, 0x6813962EB0A49AFA);
  }
}