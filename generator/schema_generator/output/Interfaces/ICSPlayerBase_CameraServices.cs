using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerBase_CameraServices : IPlayer_CameraServices {

  
  public ref uint FOV { get; }
  
  public ref uint FOVStart { get; }
  
  public IGameTime_t FOVTime { get; }
  
  public ref float FOVRate { get; }
  
  public ref CHandle<CBaseEntity> ZoomOwner { get; }
  
  public ref CUtlVector<CHandle<CBaseEntity>> TriggerFogList { get; }
  
  public ref CHandle<CBaseEntity> LastFogTrigger { get; }
}