using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvCubemap : CBaseEntity, IEnvCubemap {

  public CEnvCubemap(nint handle) : base(handle) {
  }



  public void Entity_hCubemapTextureUpdated() {
    Schema.Update(_Handle, 0xD6FB78464906C709);
  }
  public void Entity_bCustomCubemapTextureUpdated() {
    Schema.Update(_Handle, 0xD6FB78461E6DC6A4);
  }
  public void Entity_flInfluenceRadiusUpdated() {
    Schema.Update(_Handle, 0xD6FB7846C7454EDE);
  }
  public void Entity_vBoxProjectMinsUpdated() {
    Schema.Update(_Handle, 0xD6FB7846DFB51948);
  }
  public void Entity_vBoxProjectMaxsUpdated() {
    Schema.Update(_Handle, 0xD6FB7846712D3052);
  }
  public void Entity_bMoveableUpdated() {
    Schema.Update(_Handle, 0xD6FB784654059592);
  }
  public void Entity_nHandshakeUpdated() {
    Schema.Update(_Handle, 0xD6FB7846069A2774);
  }
  public void Entity_nEnvCubeMapArrayIndexUpdated() {
    Schema.Update(_Handle, 0xD6FB784621687DA4);
  }
  public void Entity_nPriorityUpdated() {
    Schema.Update(_Handle, 0xD6FB7846BAACBFAB);
  }
  public void Entity_flEdgeFadeDistUpdated() {
    Schema.Update(_Handle, 0xD6FB7846B6CBA4FE);
  }
  public void Entity_vEdgeFadeDistsUpdated() {
    Schema.Update(_Handle, 0xD6FB7846B07D9139);
  }
  public void Entity_flDiffuseScaleUpdated() {
    Schema.Update(_Handle, 0xD6FB7846A14F91F9);
  }
  public void Entity_bStartDisabledUpdated() {
    Schema.Update(_Handle, 0xD6FB7846D04F520D);
  }
  public void Entity_bDefaultEnvMapUpdated() {
    Schema.Update(_Handle, 0xD6FB784626B7497F);
  }
  public void Entity_bDefaultSpecEnvMapUpdated() {
    Schema.Update(_Handle, 0xD6FB7846D2CEAC08);
  }
  public void Entity_bIndoorCubeMapUpdated() {
    Schema.Update(_Handle, 0xD6FB7846F5F722D5);
  }
  public void Entity_bCopyDiffuseFromDefaultCubemapUpdated() {
    Schema.Update(_Handle, 0xD6FB7846DF047EA2);
  }
  public void Entity_bEnabledUpdated() {
    Schema.Update(_Handle, 0xD6FB7846453FD9DC);
  }
}