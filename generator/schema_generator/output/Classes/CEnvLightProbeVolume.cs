using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvLightProbeVolume : CBaseEntity, IEnvLightProbeVolume {

  public CEnvLightProbeVolume(nint handle) : base(handle) {
  }



  public void Entity_hLightProbeTexture_AmbientCubeUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5148FA944);
  }
  public void Entity_hLightProbeTexture_SDFUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5B0D8BE62);
  }
  public void Entity_hLightProbeTexture_SH2_DCUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5C9357F5E);
  }
  public void Entity_hLightProbeTexture_SH2_RUpdated() {
    Schema.Update(_Handle, 0xA8F87EA50E80FF9F);
  }
  public void Entity_hLightProbeTexture_SH2_GUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5198110F0);
  }
  public void Entity_hLightProbeTexture_SH2_BUpdated() {
    Schema.Update(_Handle, 0xA8F87EA51E8118CF);
  }
  public void Entity_hLightProbeDirectLightIndicesTextureUpdated() {
    Schema.Update(_Handle, 0xA8F87EA52251ACF2);
  }
  public void Entity_hLightProbeDirectLightScalarsTextureUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5A463880E);
  }
  public void Entity_hLightProbeDirectLightShadowsTextureUpdated() {
    Schema.Update(_Handle, 0xA8F87EA594B00D56);
  }
  public void Entity_vBoxMinsUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5D35AD599);
  }
  public void Entity_vBoxMaxsUpdated() {
    Schema.Update(_Handle, 0xA8F87EA57C83608B);
  }
  public void Entity_bMoveableUpdated() {
    Schema.Update(_Handle, 0xA8F87EA554059592);
  }
  public void Entity_nHandshakeUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5069A2774);
  }
  public void Entity_nPriorityUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5BAACBFAB);
  }
  public void Entity_bStartDisabledUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5D04F520D);
  }
  public void Entity_nLightProbeSizeXUpdated() {
    Schema.Update(_Handle, 0xA8F87EA59A840E10);
  }
  public void Entity_nLightProbeSizeYUpdated() {
    Schema.Update(_Handle, 0xA8F87EA59B840FA3);
  }
  public void Entity_nLightProbeSizeZUpdated() {
    Schema.Update(_Handle, 0xA8F87EA59C841136);
  }
  public void Entity_nLightProbeAtlasXUpdated() {
    Schema.Update(_Handle, 0xA8F87EA553C9E610);
  }
  public void Entity_nLightProbeAtlasYUpdated() {
    Schema.Update(_Handle, 0xA8F87EA554C9E7A3);
  }
  public void Entity_nLightProbeAtlasZUpdated() {
    Schema.Update(_Handle, 0xA8F87EA555C9E936);
  }
  public void Entity_bEnabledUpdated() {
    Schema.Update(_Handle, 0xA8F87EA5453FD9DC);
  }
}