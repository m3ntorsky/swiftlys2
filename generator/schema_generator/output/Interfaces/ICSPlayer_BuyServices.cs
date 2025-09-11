using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_BuyServices : IPlayerPawnComponent {

  
// CUtlVectorEmbeddedNetworkVar< SellbackPurchaseEntry_t >
  public ref CUtlVectorEmbeddedNetworkVar SellbackPurchaseEntries { get; }
}