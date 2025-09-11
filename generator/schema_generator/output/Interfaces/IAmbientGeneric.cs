using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAmbientGeneric : IPointEntity {

  
  public ref float Radius { get; }
  
  public ref float MaxRadius { get; }
  
  public ref soundlevel_t SoundLevel { get; }
  
  public Idynpitchvol_t Dpv { get; }
  
  public ref bool Active { get; }
  
  public ref bool Looping { get; }
  
  public ref CUtlSymbolLarge Sound { get; }
  
  public ref CUtlSymbolLarge SourceEntName { get; }
  
  public ref CHandle<CBaseEntity> SoundSource { get; }
  
  public ref CEntityIndex SoundSourceEntIndex { get; }
}