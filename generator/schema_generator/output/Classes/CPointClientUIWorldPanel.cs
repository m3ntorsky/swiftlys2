using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointClientUIWorldPanel : CBaseClientUIEntity, IPointClientUIWorldPanel {

  public CPointClientUIWorldPanel(nint handle) : base(handle) {
  }



  public void IgnoreInputUpdated() {
    Schema.Update(_Handle, 0xA4834E6F946EC6E1);
  }
  public void LitUpdated() {
    Schema.Update(_Handle, 0xA4834E6F68D14396);
  }
  public void FollowPlayerAcrossTeleportUpdated() {
    Schema.Update(_Handle, 0xA4834E6F8C71E81F);
  }
  public void WidthUpdated() {
    Schema.Update(_Handle, 0xA4834E6FB91935E1);
  }
  public void HeightUpdated() {
    Schema.Update(_Handle, 0xA4834E6FEADD7FB0);
  }
  public void DPIUpdated() {
    Schema.Update(_Handle, 0xA4834E6FEB0B7A2E);
  }
  public void InteractDistanceUpdated() {
    Schema.Update(_Handle, 0xA4834E6F47FBB4C2);
  }
  public void DepthOffsetUpdated() {
    Schema.Update(_Handle, 0xA4834E6F67D1DB9B);
  }
  public void OwnerContextUpdated() {
    Schema.Update(_Handle, 0xA4834E6FB5F5A8BC);
  }
  public void HorizontalAlignUpdated() {
    Schema.Update(_Handle, 0xA4834E6FF2F27A57);
  }
  public void VerticalAlignUpdated() {
    Schema.Update(_Handle, 0xA4834E6FC263FE8D);
  }
  public void OrientationUpdated() {
    Schema.Update(_Handle, 0xA4834E6FB9A99B4C);
  }
  public void AllowInteractionFromAllSceneWorldsUpdated() {
    Schema.Update(_Handle, 0xA4834E6FB50077AE);
  }
  public void CSSClassesUpdated() {
    Schema.Update(_Handle, 0xA4834E6FCB74D1DC);
  }
  public void OpaqueUpdated() {
    Schema.Update(_Handle, 0xA4834E6F718DB77E);
  }
  public void NoDepthUpdated() {
    Schema.Update(_Handle, 0xA4834E6F930402F3);
  }
  public void VisibleWhenParentNoDrawUpdated() {
    Schema.Update(_Handle, 0xA4834E6F894EBD44);
  }
  public void RenderBackfaceUpdated() {
    Schema.Update(_Handle, 0xA4834E6F9150ED73);
  }
  public void UseOffScreenIndicatorUpdated() {
    Schema.Update(_Handle, 0xA4834E6F83728A46);
  }
  public void ExcludeFromSaveGamesUpdated() {
    Schema.Update(_Handle, 0xA4834E6FFC6043F7);
  }
  public void GrabbableUpdated() {
    Schema.Update(_Handle, 0xA4834E6FFE2A8983);
  }
  public void OnlyRenderToTextureUpdated() {
    Schema.Update(_Handle, 0xA4834E6F52B95FF9);
  }
  public void DisableMipGenUpdated() {
    Schema.Update(_Handle, 0xA4834E6F0CB84487);
  }
  public void ExplicitImageLayoutUpdated() {
    Schema.Update(_Handle, 0xA4834E6FAFAD513C);
  }
}