using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameAmmoTypeInfo_t : IAmmoTypeInfo_t {

  
  public ref int BuySize { get; }
  
  public ref int Cost { get; }
}