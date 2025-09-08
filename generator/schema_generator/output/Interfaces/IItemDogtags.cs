using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IItemDogtags : IItem {

  public CHandle<ICSPlayerPawn> OwningPlayer { get; }
  
  public CHandle<ICSPlayerPawn> KillingPlayer { get; }
  
}