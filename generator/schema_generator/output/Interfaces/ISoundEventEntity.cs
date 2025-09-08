using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventEntity : IBaseEntity {

  public ref bool StartOnSpawn { get; }
  
  public ref bool ToLocalPlayer { get; }
  
  public ref bool StopOnNew { get; }
  
  public ref bool SaveRestore { get; }
  
  public ref bool SavedIsPlaying { get; }
  
  public ref float SavedElapsedTime { get; }
  
  public ref CUtlSymbolLarge SourceEntityName { get; }
  
  public ref CUtlSymbolLarge AttachmentName { get; }
  
  public ISchemaUntypedField OnGUIDChanged { get; }
  
  public IEntityIOOutput OnSoundFinished { get; }
  
  public ref float ClientCullRadius { get; }
  
  public ref CUtlSymbolLarge SoundName { get; }
  
  public ref CEntityHandle Source { get; }
  
  public ref int EntityIndexSelection { get; }
  
}