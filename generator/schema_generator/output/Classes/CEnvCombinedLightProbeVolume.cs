using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvCombinedLightProbeVolume : CBaseEntity, IEnvCombinedLightProbeVolume {

  public CEnvCombinedLightProbeVolume(nint handle) : base(handle) {
  }



  public void Entity_ColorUpdated() {
    Schema.Update(_Handle, 0xA73B1B927B17F98E);
  }
  public void Entity_flBrightnessUpdated() {
    Schema.Update(_Handle, 0xA73B1B92917416BA);
  }
  public void Entity_hCubemapTextureUpdated() {
    Schema.Update(_Handle, 0xA73B1B924906C709);
  }
  public void Entity_bCustomCubemapTextureUpdated() {
    Schema.Update(_Handle, 0xA73B1B921E6DC6A4);
  }
  public void Entity_hLightProbeTexture_AmbientCubeUpdated() {
    Schema.Update(_Handle, 0xA73B1B92148FA944);
  }
  public void Entity_hLightProbeTexture_SDFUpdated() {
    Schema.Update(_Handle, 0xA73B1B92B0D8BE62);
  }
  public void Entity_hLightProbeTexture_SH2_DCUpdated() {
    Schema.Update(_Handle, 0xA73B1B92C9357F5E);
  }
  public void Entity_hLightProbeTexture_SH2_RUpdated() {
    Schema.Update(_Handle, 0xA73B1B920E80FF9F);
  }
  public void Entity_hLightProbeTexture_SH2_GUpdated() {
    Schema.Update(_Handle, 0xA73B1B92198110F0);
  }
  public void Entity_hLightProbeTexture_SH2_BUpdated() {
    Schema.Update(_Handle, 0xA73B1B921E8118CF);
  }
  public void Entity_hLightProbeDirectLightIndicesTextureUpdated() {
    Schema.Update(_Handle, 0xA73B1B922251ACF2);
  }
  public void Entity_hLightProbeDirectLightScalarsTextureUpdated() {
    Schema.Update(_Handle, 0xA73B1B92A463880E);
  }
  public void Entity_hLightProbeDirectLightShadowsTextureUpdated() {
    Schema.Update(_Handle, 0xA73B1B9294B00D56);
  }
  public void Entity_vBoxMinsUpdated() {
    Schema.Update(_Handle, 0xA73B1B92D35AD599);
  }
  public void Entity_vBoxMaxsUpdated() {
    Schema.Update(_Handle, 0xA73B1B927C83608B);
  }
  public void Entity_bMoveableUpdated() {
    Schema.Update(_Handle, 0xA73B1B9254059592);
  }
  public void Entity_nHandshakeUpdated() {
    Schema.Update(_Handle, 0xA73B1B92069A2774);
  }
  public void Entity_nEnvCubeMapArrayIndexUpdated() {
    Schema.Update(_Handle, 0xA73B1B9221687DA4);
  }
  public void Entity_nPriorityUpdated() {
    Schema.Update(_Handle, 0xA73B1B92BAACBFAB);
  }
  public void Entity_bStartDisabledUpdated() {
    Schema.Update(_Handle, 0xA73B1B92D04F520D);
  }
  public void Entity_flEdgeFadeDistUpdated() {
    Schema.Update(_Handle, 0xA73B1B92B6CBA4FE);
  }
  public void Entity_vEdgeFadeDistsUpdated() {
    Schema.Update(_Handle, 0xA73B1B92B07D9139);
  }
  public void Entity_nLightProbeSizeXUpdated() {
    Schema.Update(_Handle, 0xA73B1B929A840E10);
  }
  public void Entity_nLightProbeSizeYUpdated() {
    Schema.Update(_Handle, 0xA73B1B929B840FA3);
  }
  public void Entity_nLightProbeSizeZUpdated() {
    Schema.Update(_Handle, 0xA73B1B929C841136);
  }
  public void Entity_nLightProbeAtlasXUpdated() {
    Schema.Update(_Handle, 0xA73B1B9253C9E610);
  }
  public void Entity_nLightProbeAtlasYUpdated() {
    Schema.Update(_Handle, 0xA73B1B9254C9E7A3);
  }
  public void Entity_nLightProbeAtlasZUpdated() {
    Schema.Update(_Handle, 0xA73B1B9255C9E936);
  }
  public void Entity_bEnabledUpdated() {
    Schema.Update(_Handle, 0xA73B1B92453FD9DC);
  }
}