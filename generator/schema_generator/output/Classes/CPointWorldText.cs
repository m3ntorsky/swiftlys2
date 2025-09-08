using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointWorldText : CModelPointEntity, IPointWorldText {

  public CPointWorldText(nint handle) : base(handle) {
  }



  public void MessageTextUpdated() {
    Schema.Update(_Handle, 0x5BF88697BA6E5D73);
  }
  public void FontNameUpdated() {
    Schema.Update(_Handle, 0x5BF88697C241C2B3);
  }
  public void BackgroundMaterialNameUpdated() {
    Schema.Update(_Handle, 0x5BF88697ECF8A7AB);
  }
  public void EnabledUpdated() {
    Schema.Update(_Handle, 0x5BF886976154EB7E);
  }
  public void FullbrightUpdated() {
    Schema.Update(_Handle, 0x5BF8869765A288E8);
  }
  public void WorldUnitsPerPxUpdated() {
    Schema.Update(_Handle, 0x5BF886971DA8EAAB);
  }
  public void FontSizeUpdated() {
    Schema.Update(_Handle, 0x5BF88697D5E19F97);
  }
  public void DepthOffsetUpdated() {
    Schema.Update(_Handle, 0x5BF8869767D1DB9B);
  }
  public void DrawBackgroundUpdated() {
    Schema.Update(_Handle, 0x5BF886978259FA8F);
  }
  public void BackgroundBorderWidthUpdated() {
    Schema.Update(_Handle, 0x5BF886972A7C9A4F);
  }
  public void BackgroundBorderHeightUpdated() {
    Schema.Update(_Handle, 0x5BF8869794198B72);
  }
  public void BackgroundWorldToUVUpdated() {
    Schema.Update(_Handle, 0x5BF88697ECA00D93);
  }
  public void ColorUpdated() {
    Schema.Update(_Handle, 0x5BF88697D7D017D8);
  }
  public void JustifyHorizontalUpdated() {
    Schema.Update(_Handle, 0x5BF8869730435253);
  }
  public void JustifyVerticalUpdated() {
    Schema.Update(_Handle, 0x5BF88697CA04D41D);
  }
  public void ReorientModeUpdated() {
    Schema.Update(_Handle, 0x5BF88697222D2502);
  }
}