using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITankTrainAI : IPointEntity {

  
  public ref CHandle<CFuncTrackTrain> Train { get; }
  
  public ref CHandle<CBaseEntity> TargetEntity { get; }
  
  public ref int SoundPlaying { get; }
  
  public ISchemaUntypedField StartSoundName { get; }
  
  public ISchemaUntypedField EngineSoundName { get; }
  
  public ISchemaUntypedField MovementSoundName { get; }
  
  public ISchemaUntypedField TargetEntityName { get; }
}