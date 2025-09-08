using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IColorCorrection : IBaseEntity {

  public ref float FadeInDuration { get; }
  
  public ref float FadeOutDuration { get; }
  
  public ref float StartFadeInWeight { get; }
  
  public ref float StartFadeOutWeight { get; }
  
  public IGameTime_t TimeStartFadeIn { get; }
  
  public IGameTime_t TimeStartFadeOut { get; }
  
  public ref float MaxWeight { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref bool Enabled { get; }
  
  public ref bool Master { get; }
  
  public ref bool ClientSide { get; }
  
  public ref bool Exclusive { get; }
  
  public ref float MinFalloff { get; }
  
  public ref float MaxFalloff { get; }
  
  public ref float CurWeight { get; }
  
  public ISchemaFixedString NetlookupFilename { get; }
  
  public ref CUtlSymbolLarge LookupFilename { get; }
  
}