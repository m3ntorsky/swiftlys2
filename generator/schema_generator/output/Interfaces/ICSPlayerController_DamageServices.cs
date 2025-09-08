using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerController_DamageServices : IPlayerControllerComponent {

  public ref int SendUpdate { get; }
  
  public ref CUtlVectorEmbeddedNetworkVar DamageList { get; }
  
}