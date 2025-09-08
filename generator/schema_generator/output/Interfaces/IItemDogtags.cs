using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IItemDogtags : IItem {

  public ref CHandle<CCSPlayerPawn> OwningPlayer { get; }
  
  public ref CHandle<CCSPlayerPawn> KillingPlayer { get; }
  
}