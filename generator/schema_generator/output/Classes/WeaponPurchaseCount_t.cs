using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class WeaponPurchaseCount_t : SchemaClass, IWeaponPurchaseCount_t {

  public WeaponPurchaseCount_t(nint handle) : base(handle) {
  }



  public void ItemDefIndexUpdated() {
    Schema.Update(_Handle, 0xF7F0C6E61BF10FB7);
  }
  public void CountUpdated() {
    Schema.Update(_Handle, 0xF7F0C6E67D31AC08);
  }
}