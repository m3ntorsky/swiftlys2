using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBarnLight : CBaseModelEntity, IBarnLight {

  public CBarnLight(nint handle) : base(handle) {
  }

  public IEntityIOOutput StyleEvent {
    get => new CEntityIOOutput(_Handle, 0xB5E331D15EEF4062, 4, 40, 8);
  }
  public ref bool PvsModifyEntity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB5E331D133895595));
  }

  public void EnabledUpdated() {
    Schema.Update(_Handle, 0xB5E331D16154EB7E);
  }
  public void ColorModeUpdated() {
    Schema.Update(_Handle, 0xB5E331D135E5C3F7);
  }
  public void ColorUpdated() {
    Schema.Update(_Handle, 0xB5E331D1D7D017D8);
  }
  public void ColorTemperatureUpdated() {
    Schema.Update(_Handle, 0xB5E331D1E9FB4614);
  }
  public void BrightnessUpdated() {
    Schema.Update(_Handle, 0xB5E331D19132D314);
  }
  public void BrightnessScaleUpdated() {
    Schema.Update(_Handle, 0xB5E331D15EFC3AAE);
  }
  public void DirectLightUpdated() {
    Schema.Update(_Handle, 0xB5E331D1DEC0AAB4);
  }
  public void BakedShadowIndexUpdated() {
    Schema.Update(_Handle, 0xB5E331D1D4F129E0);
  }
  public void LightPathUniqueIdUpdated() {
    Schema.Update(_Handle, 0xB5E331D18626C8FE);
  }
  public void LightMapUniqueIdUpdated() {
    Schema.Update(_Handle, 0xB5E331D18E111BB5);
  }
  public void LuminaireShapeUpdated() {
    Schema.Update(_Handle, 0xB5E331D1F648BF4A);
  }
  public void LuminaireSizeUpdated() {
    Schema.Update(_Handle, 0xB5E331D185EECB6A);
  }
  public void LuminaireAnisotropyUpdated() {
    Schema.Update(_Handle, 0xB5E331D1A50CAFAF);
  }
  public void LightStyleStringUpdated() {
    Schema.Update(_Handle, 0xB5E331D135505939);
  }
  public void LightStyleStartTimeUpdated() {
    Schema.Update(_Handle, 0xB5E331D1A3B159A3);
  }
  public void QueuedLightStyleStringsUpdated() {
    Schema.Update(_Handle, 0xB5E331D1635061E9);
  }
  public void LightStyleEventsUpdated() {
    Schema.Update(_Handle, 0xB5E331D15CAA0F51);
  }
  public void LightStyleTargetsUpdated() {
    Schema.Update(_Handle, 0xB5E331D1FA0DC93E);
  }
  public void LightCookieUpdated() {
    Schema.Update(_Handle, 0xB5E331D10609D103);
  }
  public void ShapeUpdated() {
    Schema.Update(_Handle, 0xB5E331D15DCE07D8);
  }
  public void SoftXUpdated() {
    Schema.Update(_Handle, 0xB5E331D1ED19BFA1);
  }
  public void SoftYUpdated() {
    Schema.Update(_Handle, 0xB5E331D1EC19BE0E);
  }
  public void SkirtUpdated() {
    Schema.Update(_Handle, 0xB5E331D1EAFB6D2A);
  }
  public void SkirtNearUpdated() {
    Schema.Update(_Handle, 0xB5E331D15CE2A8E4);
  }
  public void SizeParamsUpdated() {
    Schema.Update(_Handle, 0xB5E331D187414B4E);
  }
  public void RangeUpdated() {
    Schema.Update(_Handle, 0xB5E331D13FC92844);
  }
  public void ShearUpdated() {
    Schema.Update(_Handle, 0xB5E331D1F044CF2A);
  }
  public void BakeSpecularToCubemapsUpdated() {
    Schema.Update(_Handle, 0xB5E331D172208D6A);
  }
  public void BakeSpecularToCubemapsSizeUpdated() {
    Schema.Update(_Handle, 0xB5E331D1A4CF804B);
  }
  public void CastShadowsUpdated() {
    Schema.Update(_Handle, 0xB5E331D151564EBB);
  }
  public void ShadowMapSizeUpdated() {
    Schema.Update(_Handle, 0xB5E331D1163F44B0);
  }
  public void ShadowPriorityUpdated() {
    Schema.Update(_Handle, 0xB5E331D115B296B9);
  }
  public void ContactShadowUpdated() {
    Schema.Update(_Handle, 0xB5E331D13C0922B3);
  }
  public void ForceShadowsEnabledUpdated() {
    Schema.Update(_Handle, 0xB5E331D179F7B762);
  }
  public void BounceLightUpdated() {
    Schema.Update(_Handle, 0xB5E331D17A8E13D3);
  }
  public void BounceScaleUpdated() {
    Schema.Update(_Handle, 0xB5E331D1918AF747);
  }
  public void MinRoughnessUpdated() {
    Schema.Update(_Handle, 0xB5E331D1B3A6FDC9);
  }
  public void AlternateColorUpdated() {
    Schema.Update(_Handle, 0xB5E331D1A6BAD29C);
  }
  public void AlternateColorBrightnessUpdated() {
    Schema.Update(_Handle, 0xB5E331D14C877943);
  }
  public void FogUpdated() {
    Schema.Update(_Handle, 0xB5E331D1B855CC6B);
  }
  public void FogStrengthUpdated() {
    Schema.Update(_Handle, 0xB5E331D12DCA8F14);
  }
  public void FogShadowsUpdated() {
    Schema.Update(_Handle, 0xB5E331D1D0C53238);
  }
  public void FogScaleUpdated() {
    Schema.Update(_Handle, 0xB5E331D1CF999E05);
  }
  public void FogMixedShadowsUpdated() {
    Schema.Update(_Handle, 0xB5E331D17FAB6DC7);
  }
  public void FadeSizeStartUpdated() {
    Schema.Update(_Handle, 0xB5E331D17D0D6C9C);
  }
  public void FadeSizeEndUpdated() {
    Schema.Update(_Handle, 0xB5E331D14D20D885);
  }
  public void ShadowFadeSizeStartUpdated() {
    Schema.Update(_Handle, 0xB5E331D1D2A843D4);
  }
  public void ShadowFadeSizeEndUpdated() {
    Schema.Update(_Handle, 0xB5E331D16A79DE2D);
  }
  public void PrecomputedFieldsValidUpdated() {
    Schema.Update(_Handle, 0xB5E331D191C883D6);
  }
  public void PrecomputedBoundsMinsUpdated() {
    Schema.Update(_Handle, 0xB5E331D16F3FE3C1);
  }
  public void PrecomputedBoundsMaxsUpdated() {
    Schema.Update(_Handle, 0xB5E331D1C5E5BC03);
  }
  public void PrecomputedOBBOriginUpdated() {
    Schema.Update(_Handle, 0xB5E331D1D6D011C8);
  }
  public void PrecomputedOBBAnglesUpdated() {
    Schema.Update(_Handle, 0xB5E331D189054822);
  }
  public void PrecomputedOBBExtentUpdated() {
    Schema.Update(_Handle, 0xB5E331D185AE2732);
  }
  public void PrecomputedSubFrustaUpdated() {
    Schema.Update(_Handle, 0xB5E331D1190230CA);
  }
  public void PrecomputedOBBOrigin0Updated() {
    Schema.Update(_Handle, 0xB5E331D1218C4968);
  }
  public void PrecomputedOBBAngles0Updated() {
    Schema.Update(_Handle, 0xB5E331D1C5507456);
  }
  public void PrecomputedOBBExtent0Updated() {
    Schema.Update(_Handle, 0xB5E331D173276826);
  }
  public void PrecomputedOBBOrigin1Updated() {
    Schema.Update(_Handle, 0xB5E331D1228C4AFB);
  }
  public void PrecomputedOBBAngles1Updated() {
    Schema.Update(_Handle, 0xB5E331D1C65075E9);
  }
  public void PrecomputedOBBExtent1Updated() {
    Schema.Update(_Handle, 0xB5E331D1742769B9);
  }
  public void PrecomputedOBBOrigin2Updated() {
    Schema.Update(_Handle, 0xB5E331D1238C4C8E);
  }
  public void PrecomputedOBBAngles2Updated() {
    Schema.Update(_Handle, 0xB5E331D1C3507130);
  }
  public void PrecomputedOBBExtent2Updated() {
    Schema.Update(_Handle, 0xB5E331D171276500);
  }
  public void PrecomputedOBBOrigin3Updated() {
    Schema.Update(_Handle, 0xB5E331D1248C4E21);
  }
  public void PrecomputedOBBAngles3Updated() {
    Schema.Update(_Handle, 0xB5E331D1C45072C3);
  }
  public void PrecomputedOBBExtent3Updated() {
    Schema.Update(_Handle, 0xB5E331D172276693);
  }
  public void PrecomputedOBBOrigin4Updated() {
    Schema.Update(_Handle, 0xB5E331D1258C4FB4);
  }
  public void PrecomputedOBBAngles4Updated() {
    Schema.Update(_Handle, 0xB5E331D1C9507AA2);
  }
  public void PrecomputedOBBExtent4Updated() {
    Schema.Update(_Handle, 0xB5E331D177276E72);
  }
  public void PrecomputedOBBOrigin5Updated() {
    Schema.Update(_Handle, 0xB5E331D1268C5147);
  }
  public void PrecomputedOBBAngles5Updated() {
    Schema.Update(_Handle, 0xB5E331D1CA507C35);
  }
  public void PrecomputedOBBExtent5Updated() {
    Schema.Update(_Handle, 0xB5E331D178277005);
  }
  public void VisClustersUpdated() {
    Schema.Update(_Handle, 0xB5E331D19E97C0CE);
  }
}