using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerPawnBase : IBasePlayerPawn {

  public ITouchExpansionComponent CTouchExpansionComponent { get; }
  
  public ICSPlayer_PingServices PingServices { get; }
  
  public IGameTime_t BlindUntilTime { get; }
  
  public IGameTime_t BlindStartTime { get; }
  
  public ref CSPlayerState PlayerState { get; }
  
  public ref bool Respawning { get; }
  
  public ref bool HasMovedSinceSpawn { get; }
  
  public ref int NumSpawns { get; }
  
  public ref float IdleTimeSinceLastAction { get; }
  
  public ref float NextRadarUpdateTime { get; }
  
  public ref float FlashDuration { get; }
  
  public ref float FlashMaxAlpha { get; }
  
  public ref float ProgressBarStartTime { get; }
  
  public ref int ProgressBarDuration { get; }
  
  public ref CHandle<CCSPlayerController> OriginalController { get; }
  
}