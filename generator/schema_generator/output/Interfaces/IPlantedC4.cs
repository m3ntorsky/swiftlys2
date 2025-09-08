using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlantedC4 : IBaseAnimGraph {

  public ref bool BombTicking { get; }
  
  public IGameTime_t C4Blow { get; }
  
  public ref int BombSite { get; }
  
  public ref int SourceSoundscapeHash { get; }
  
  public IAttributeContainer AttributeManager { get; }
  
  public IEntityIOOutput OnBombDefused { get; }
  
  public IEntityIOOutput OnBombBeginDefuse { get; }
  
  public IEntityIOOutput OnBombDefuseAborted { get; }
  
  public ref bool CannotBeDefused { get; }
  
  public IEntitySpottedState_t EntitySpottedState { get; }
  
  public ref int SpotRules { get; }
  
  public ref bool TrainingPlacedByPlayer { get; }
  
  public ref bool HasExploded { get; }
  
  public ref float TimerLength { get; }
  
  public ref bool BeingDefused { get; }
  
  public IGameTime_t LastDefuseTime { get; }
  
  public ref float DefuseLength { get; }
  
  public IGameTime_t DefuseCountDown { get; }
  
  public ref bool BombDefused { get; }
  
  public CHandle<ICSPlayerPawn> BombDefuser { get; }
  
  public ref int ProgressBarTime { get; }
  
  public ref bool VoiceAlertFired { get; }
  
  public ISchemaFixedArray<bool> VoiceAlertPlayed { get; }
  
  public IGameTime_t NextBotBeepTime { get; }
  
  public ref QAngle CatchUpToPlayerEye { get; }
  
  public IGameTime_t LastSpinDetectionTime { get; }
  
}