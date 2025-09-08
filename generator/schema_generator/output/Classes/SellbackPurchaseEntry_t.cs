using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SellbackPurchaseEntry_t : SchemaClass, ISellbackPurchaseEntry_t {

  public SellbackPurchaseEntry_t(nint handle) : base(handle) {
  }



  public void DefIdxUpdated() {
    Schema.Update(_Handle, 0xAC9E0914F02DD274);
  }
  public void CostUpdated() {
    Schema.Update(_Handle, 0xAC9E0914919660C4);
  }
  public void PrevArmorUpdated() {
    Schema.Update(_Handle, 0xAC9E09143A18A19B);
  }
  public void PrevHelmetUpdated() {
    Schema.Update(_Handle, 0xAC9E0914DA638D65);
  }
  public void ItemUpdated() {
    Schema.Update(_Handle, 0xAC9E091452FF0710);
  }
}