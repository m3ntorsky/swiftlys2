using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_UseServices : IPlayer_UseServices {

  public CHandle<IBaseEntity> LastKnownUseEntity { get; }
  
  public IGameTime_t LastUseTimeStamp { get; }
  
  public IGameTime_t TimeLastUsedWindow { get; }
  
}