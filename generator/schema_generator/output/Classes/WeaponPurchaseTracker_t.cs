using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class WeaponPurchaseTracker_t : SchemaClass, IWeaponPurchaseTracker_t {

  public WeaponPurchaseTracker_t(nint handle) : base(handle) {
  }



  public void WeaponPurchasesUpdated() {
    Schema.Update(_Handle, 0xD558F475988247C7);
  }
}