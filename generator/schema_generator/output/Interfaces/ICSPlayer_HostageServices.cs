using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_HostageServices : IPlayerPawnComponent {

  public CHandle<IBaseEntity> CarriedHostage { get; }
  
  public CHandle<IBaseEntity> CarriedHostageProp { get; }
  
}