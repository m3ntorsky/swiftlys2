using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_HostageServices : IPlayerPawnComponent {

  public ref CHandle<CBaseEntity> CarriedHostage { get; }
  
  public ref CHandle<CBaseEntity> CarriedHostageProp { get; }
  
}