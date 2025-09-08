using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerBase_CameraServices : IPlayer_CameraServices {

  public ref uint FOV { get; }
  
  public ref uint FOVStart { get; }
  
  public IGameTime_t FOVTime { get; }
  
  public ref float FOVRate { get; }
  
  public CHandle<IBaseEntity> ZoomOwner { get; }
  
  public ref CUtlVector TriggerFogList { get; }
  
  public CHandle<IBaseEntity> LastFogTrigger { get; }
  
}