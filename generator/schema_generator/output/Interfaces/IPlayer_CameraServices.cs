using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayer_CameraServices : IPlayerPawnComponent {

  public ref QAngle CsViewPunchAngle { get; }
  
  public IGameTick_t CsViewPunchAngleTick { get; }
  
  public ref float CsViewPunchAngleTickRatio { get; }
  
  public Ifogplayerparams_t PlayerFog { get; }
  
  public ref CHandle<CColorCorrection> ColorCorrectionCtrl { get; }
  
  public ref CHandle<CBaseEntity> ViewEntity { get; }
  
  public ref CHandle<CTonemapController2> TonemapController { get; }
  
  public Iaudioparams_t Audio { get; }
  
  public ref CUtlVector<CHandle<CPostProcessingVolume>> PostProcessingVolumes { get; }
  
  public ref float OldPlayerZ { get; }
  
  public ref float OldPlayerViewOffsetZ { get; }
  
  public ref CUtlVector<CHandle<CEnvSoundscapeTriggerable>> TriggerSoundscapeList { get; }
  
}