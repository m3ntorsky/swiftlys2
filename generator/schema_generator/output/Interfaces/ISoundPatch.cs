using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundPatch : ISchemaClass {

  public ISoundEnvelope Pitch { get; }
  
  public ISoundEnvelope Volume { get; }
  
  public ref float ShutdownTime { get; }
  
  public ref float LastTime { get; }
  
  public ref CUtlSymbolLarge SoundScriptName { get; }
  
  public CHandle<IBaseEntity> Ent { get; }
  
  public ref CEntityIndex SoundEntityIndex { get; }
  
  public ref Vector SoundOrigin { get; }
  
  public ref int IsPlaying { get; }
  
  public ICopyRecipientFilter Filter { get; }
  
  public ref float CloseCaptionDuration { get; }
  
  public ref bool UpdatedSoundOrigin { get; }
  
  public ref CUtlSymbolLarge ClassName { get; }
  
}