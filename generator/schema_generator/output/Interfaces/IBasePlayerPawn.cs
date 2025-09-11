using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBasePlayerPawn : IBaseCombatCharacter {

  
  public IPlayer_WeaponServices WeaponServices { get; }
  
  public IPlayer_ItemServices ItemServices { get; }
  
  public IPlayer_AutoaimServices AutoaimServices { get; }
  
  public IPlayer_ObserverServices ObserverServices { get; }
  
  public IPlayer_WaterServices WaterServices { get; }
  
  public IPlayer_UseServices UseServices { get; }
  
  public IPlayer_FlashlightServices FlashlightServices { get; }
  
  public IPlayer_CameraServices CameraServices { get; }
  
  public IPlayer_MovementServices MovementServices { get; }
  
// CUtlVectorEmbeddedNetworkVar< ViewAngleServerChange_t >
  public ref CUtlVectorEmbeddedNetworkVar ServerViewAngleChanges { get; }
  
  public ref QAngle V_angle { get; }
  
  public ref QAngle V_anglePrevious { get; }
  
  public ref uint HideHUD { get; }
  
  public Isky3dparams_t Skybox3d { get; }
  
  public IGameTime_t TimeLastHurt { get; }
  
  public IGameTime_t DeathTime { get; }
  
  public IGameTime_t NextSuicideTime { get; }
  
  public ref bool InitHUD { get; }
  
  public IAI_Expresser Expresser { get; }
  
  public ref CHandle<CBasePlayerController> Controller { get; }
  
  public ref CHandle<CBasePlayerController> DefaultController { get; }
  
  public ref float HltvReplayDelay { get; }
  
  public ref float HltvReplayEnd { get; }
  
  public ref CEntityIndex HltvReplayEntity { get; }
  
// CUtlVector< sndopvarlatchdata_t >
  public ref CUtlVector SndOpvarLatchData { get; }
}