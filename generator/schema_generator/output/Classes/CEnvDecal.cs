using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvDecal : CBaseModelEntity, IEnvDecal {

  public CEnvDecal(nint handle) : base(handle) {
  }

  public CEnvDecal(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > DecalMaterial {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0xF52AFA9ED892BA39));
  }
  public ref float Width {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF52AFA9EB91935E1));
  }
  public ref float Height {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF52AFA9EEADD7FB0));
  }
  public ref float Depth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF52AFA9ED3AD54E8));
  }
  public ref uint RenderOrder {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xF52AFA9E554E763B));
  }
  public ref bool ProjectOnWorld {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF52AFA9E213B0285));
  }
  public ref bool ProjectOnCharacters {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF52AFA9EE0371FB7));
  }
  public ref bool ProjectOnWater {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF52AFA9ED4AF2E96));
  }
  public ref float DepthSortBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF52AFA9ED8EE79D9));
  }

  public void DecalMaterialUpdated() {
    Schema.Update(_Handle, 0xF52AFA9ED892BA39);
  }
  public void WidthUpdated() {
    Schema.Update(_Handle, 0xF52AFA9EB91935E1);
  }
  public void HeightUpdated() {
    Schema.Update(_Handle, 0xF52AFA9EEADD7FB0);
  }
  public void DepthUpdated() {
    Schema.Update(_Handle, 0xF52AFA9ED3AD54E8);
  }
  public void RenderOrderUpdated() {
    Schema.Update(_Handle, 0xF52AFA9E554E763B);
  }
  public void ProjectOnWorldUpdated() {
    Schema.Update(_Handle, 0xF52AFA9E213B0285);
  }
  public void ProjectOnCharactersUpdated() {
    Schema.Update(_Handle, 0xF52AFA9EE0371FB7);
  }
  public void ProjectOnWaterUpdated() {
    Schema.Update(_Handle, 0xF52AFA9ED4AF2E96);
  }
  public void DepthSortBiasUpdated() {
    Schema.Update(_Handle, 0xF52AFA9ED8EE79D9);
  }
}