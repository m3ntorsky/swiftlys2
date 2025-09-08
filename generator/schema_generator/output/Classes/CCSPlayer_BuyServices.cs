using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_BuyServices : CPlayerPawnComponent, ICSPlayer_BuyServices {

  public CCSPlayer_BuyServices(nint handle) : base(handle) {
  }



  public void SellbackPurchaseEntriesUpdated() {
    Schema.Update(_Handle, 0xF0C2C12231D8CF7F);
  }
}