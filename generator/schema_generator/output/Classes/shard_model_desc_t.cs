using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class shard_model_desc_t : SchemaClass, Ishard_model_desc_t {

  public shard_model_desc_t(nint handle) : base(handle) {
  }

  public shard_model_desc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ModelID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x89B25B20B2007E9B));
  }
  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > MaterialBase {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0x89B25B201F6E1593));
  }
  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > MaterialDamageOverlay {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0x89B25B200B167839));
  }
  public ref ShardSolid_t Solid {
    get => ref _Handle.AsRef<ShardSolid_t>(Schema.GetOffset(0x89B25B20F14DA214));
  }
  public ref Vector2D PanelSize {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x89B25B20E61D2D9C));
  }
  public ref Vector2D StressPositionA {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x89B25B20107A2271));
  }
  public ref Vector2D StressPositionB {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x89B25B200D7A1DB8));
  }
  public ref CUtlVector< Vector2D > PanelVertices {
    get => ref _Handle.AsRef<CUtlVector< Vector2D >>(Schema.GetOffset(0x89B25B2049BB3ECE));
  }
  public ref CUtlVector< Vector4D > InitialPanelVertices {
    get => ref _Handle.AsRef<CUtlVector< Vector4D >>(Schema.GetOffset(0x89B25B2039117F58));
  }
  public ref float GlassHalfThickness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x89B25B20359D8B9E));
  }
  public ref bool HasParent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x89B25B20A613E04B));
  }
  public ref bool ParentFrozen {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x89B25B206FE526AB));
  }
  public ref CUtlStringToken SurfacePropStringToken {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x89B25B2055336E6D));
  }

  public void ModelIDUpdated() {
    Schema.Update(_Handle, 0x89B25B20B2007E9B);
  }
  public void MaterialBaseUpdated() {
    Schema.Update(_Handle, 0x89B25B201F6E1593);
  }
  public void MaterialDamageOverlayUpdated() {
    Schema.Update(_Handle, 0x89B25B200B167839);
  }
  public void SolidUpdated() {
    Schema.Update(_Handle, 0x89B25B20F14DA214);
  }
  public void PanelSizeUpdated() {
    Schema.Update(_Handle, 0x89B25B20E61D2D9C);
  }
  public void StressPositionAUpdated() {
    Schema.Update(_Handle, 0x89B25B20107A2271);
  }
  public void StressPositionBUpdated() {
    Schema.Update(_Handle, 0x89B25B200D7A1DB8);
  }
  public void PanelVerticesUpdated() {
    Schema.Update(_Handle, 0x89B25B2049BB3ECE);
  }
  public void InitialPanelVerticesUpdated() {
    Schema.Update(_Handle, 0x89B25B2039117F58);
  }
  public void GlassHalfThicknessUpdated() {
    Schema.Update(_Handle, 0x89B25B20359D8B9E);
  }
  public void HasParentUpdated() {
    Schema.Update(_Handle, 0x89B25B20A613E04B);
  }
  public void ParentFrozenUpdated() {
    Schema.Update(_Handle, 0x89B25B206FE526AB);
  }
  public void SurfacePropStringTokenUpdated() {
    Schema.Update(_Handle, 0x89B25B2055336E6D);
  }
}