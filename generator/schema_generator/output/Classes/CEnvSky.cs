using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvSky : CBaseModelEntity, IEnvSky {

  public CEnvSky(nint handle) : base(handle) {
  }



  public void SkyMaterialUpdated() {
    Schema.Update(_Handle, 0x34E51BE6C887319D);
  }
  public void SkyMaterialLightingOnlyUpdated() {
    Schema.Update(_Handle, 0x34E51BE6E01C512B);
  }
  public void StartDisabledUpdated() {
    Schema.Update(_Handle, 0x34E51BE661ED0C4F);
  }
  public void TintColorUpdated() {
    Schema.Update(_Handle, 0x34E51BE650AFF21F);
  }
  public void TintColorLightingOnlyUpdated() {
    Schema.Update(_Handle, 0x34E51BE6D8D1D8C9);
  }
  public void BrightnessScaleUpdated() {
    Schema.Update(_Handle, 0x34E51BE65EFC3AAE);
  }
  public void FogTypeUpdated() {
    Schema.Update(_Handle, 0x34E51BE6381735D3);
  }
  public void FogMinStartUpdated() {
    Schema.Update(_Handle, 0x34E51BE62D8BACA9);
  }
  public void FogMinEndUpdated() {
    Schema.Update(_Handle, 0x34E51BE69BF661F8);
  }
  public void FogMaxStartUpdated() {
    Schema.Update(_Handle, 0x34E51BE6DACCD72F);
  }
  public void FogMaxEndUpdated() {
    Schema.Update(_Handle, 0x34E51BE61D0E34BA);
  }
  public void EnabledUpdated() {
    Schema.Update(_Handle, 0x34E51BE66154EB7E);
  }
}