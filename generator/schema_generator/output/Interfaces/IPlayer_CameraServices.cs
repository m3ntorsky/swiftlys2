using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayer_CameraServices : IPlayerPawnComponent {

  public ref QAngle CsViewPunchAngle { get; }
  
  public IGameTick_t CsViewPunchAngleTick { get; }
  
  public ref float CsViewPunchAngleTickRatio { get; }
  
  public Ifogplayerparams_t PlayerFog { get; }
  
  public CHandle<IColorCorrection> ColorCorrectionCtrl { get; }
  
  public CHandle<IBaseEntity> ViewEntity { get; }
  
  public CHandle<ITonemapController2> TonemapController { get; }
  
  public Iaudioparams_t Audio { get; }
  
  public ref CUtlVector PostProcessingVolumes { get; }
  
  public ref float OldPlayerZ { get; }
  
  public ref float OldPlayerViewOffsetZ { get; }
  
  public ref CUtlVector TriggerSoundscapeList { get; }
  
}