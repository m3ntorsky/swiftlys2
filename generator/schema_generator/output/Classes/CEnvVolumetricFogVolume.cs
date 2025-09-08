using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvVolumetricFogVolume : CBaseEntity, IEnvVolumetricFogVolume {

  public CEnvVolumetricFogVolume(nint handle) : base(handle) {
  }



  public void ActiveUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD8334208F);
  }
  public void BoxMinsUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBDD8201373);
  }
  public void BoxMaxsUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD817A3B31);
  }
  public void StartDisabledUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD61ED0C4F);
  }
  public void IndirectUseLPVsUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBDF6508E3D);
  }
  public void StrengthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD8F67AF1A);
  }
  public void FalloffShapeUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD413F21CA);
  }
  public void FalloffExponentUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBDE4B7D948);
  }
  public void HeightFogDepthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBDE7A4BA15);
  }
  public void HeightFogEdgeWidthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD4605AE81);
  }
  public void IndirectLightStrengthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD1CE20160);
  }
  public void SunLightStrengthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBDDE47D3A2);
  }
  public void NoiseStrengthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD556ED5D0);
  }
  public void TintColorUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBDAF2613F3);
  }
  public void OverrideTintColorUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBDF384934B);
  }
  public void OverrideIndirectLightStrengthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD9AA2A58C);
  }
  public void OverrideSunLightStrengthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD892B7A46);
  }
  public void OverrideNoiseStrengthUpdated() {
    Schema.Update(_Handle, 0x5EDE5CBD47655E8C);
  }
}