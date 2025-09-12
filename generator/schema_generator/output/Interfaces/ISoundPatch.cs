using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundPatch : ISchemaClass {

  
  public ISoundEnvelope Pitch { get; }
  
  public ISoundEnvelope Volume { get; }
  
  public ref float ShutdownTime { get; }
  
  public ref float LastTime { get; }
  
  public ISchemaUntypedField SoundScriptName { get; }
  
  public ref CHandle<CBaseEntity> Ent { get; }
  
  public ref uint SoundEntityIndex { get; }
  
  public ref Vector SoundOrigin { get; }
  
  public ref int IsPlaying { get; }
  
  public ICopyRecipientFilter Filter { get; }
  
  public ref float CloseCaptionDuration { get; }
  
  public ref bool UpdatedSoundOrigin { get; }
  
  public ISchemaUntypedField ClassName { get; }
}