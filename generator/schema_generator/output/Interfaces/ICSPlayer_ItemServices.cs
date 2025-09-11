using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_ItemServices : IPlayer_ItemServices {

  
  public ref bool HasDefuser { get; }
  
  public ref bool HasHelmet { get; }
}