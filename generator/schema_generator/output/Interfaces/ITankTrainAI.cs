using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITankTrainAI : IPointEntity {

  public CHandle<IFuncTrackTrain> Train { get; }
  
  public CHandle<IBaseEntity> TargetEntity { get; }
  
  public ref int SoundPlaying { get; }
  
  public ref CUtlSymbolLarge StartSoundName { get; }
  
  public ref CUtlSymbolLarge EngineSoundName { get; }
  
  public ref CUtlSymbolLarge MovementSoundName { get; }
  
  public ref CUtlSymbolLarge TargetEntityName { get; }
  
}