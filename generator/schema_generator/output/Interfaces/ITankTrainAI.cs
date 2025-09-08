using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITankTrainAI : IPointEntity {

  public ref CHandle<CFuncTrackTrain> Train { get; }
  
  public ref CHandle<CBaseEntity> TargetEntity { get; }
  
  public ref int SoundPlaying { get; }
  
  public ref CUtlSymbolLarge StartSoundName { get; }
  
  public ref CUtlSymbolLarge EngineSoundName { get; }
  
  public ref CUtlSymbolLarge MovementSoundName { get; }
  
  public ref CUtlSymbolLarge TargetEntityName { get; }
  
}