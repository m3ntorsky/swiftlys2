using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class shard_model_desc_t : SchemaClass, Ishard_model_desc_t {

  public shard_model_desc_t(nint handle) : base(handle) {
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