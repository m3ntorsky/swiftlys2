using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoOffscreenPanoramaTexture : CPointEntity, IInfoOffscreenPanoramaTexture {

  public CInfoOffscreenPanoramaTexture(nint handle) : base(handle) {
  }

  public ISchemaUntypedField TargetsName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x584660AF82C9ED45));
  }
  public ref CUtlVector<CHandle<CBaseModelEntity>> AdditionalTargetEntities {
    get => ref _Handle.AsRef<CUtlVector<CHandle<CBaseModelEntity>>>(Schema.GetOffset(0x584660AFD38E792A));
  }

  public void DisabledUpdated() {
    Schema.Update(_Handle, 0x584660AF3A7C5965);
  }
  public void ResolutionXUpdated() {
    Schema.Update(_Handle, 0x584660AF6C22DC51);
  }
  public void ResolutionYUpdated() {
    Schema.Update(_Handle, 0x584660AF6B22DABE);
  }
  public void LayoutFileNameUpdated() {
    Schema.Update(_Handle, 0x584660AF5D1172FB);
  }
  public void RenderAttrNameUpdated() {
    Schema.Update(_Handle, 0x584660AFE624CDC1);
  }
  public void TargetEntitiesUpdated() {
    Schema.Update(_Handle, 0x584660AFA0100A93);
  }
  public void TargetChangeCountUpdated() {
    Schema.Update(_Handle, 0x584660AF309CAEAB);
  }
  public void CSSClassesUpdated() {
    Schema.Update(_Handle, 0x584660AFCB74D1DC);
  }
}