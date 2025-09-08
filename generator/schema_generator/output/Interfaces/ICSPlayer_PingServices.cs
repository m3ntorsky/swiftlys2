using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_PingServices : IPlayerPawnComponent {

  public IGameTime_t PlayerPingTokens { get; }
  
  public ref CHandle<CBaseEntity> PlayerPing { get; }
  
}