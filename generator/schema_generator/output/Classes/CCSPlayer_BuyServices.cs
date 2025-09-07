using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_BuyServices : CPlayerPawnComponent, ICSPlayer_BuyServices {

  public CCSPlayer_BuyServices(nint handle) : base(handle) {
  }

  public CCSPlayer_BuyServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVectorEmbeddedNetworkVar< SellbackPurchaseEntry_t > SellbackPurchaseEntries {
    get => ref _Handle.AsRef<CUtlVectorEmbeddedNetworkVar< SellbackPurchaseEntry_t >>(Schema.GetOffset(0xF0C2C12231D8CF7F));
  }

  public void SellbackPurchaseEntriesUpdated() {
    Schema.Update(_Handle, 0xF0C2C12231D8CF7F);
  }
}