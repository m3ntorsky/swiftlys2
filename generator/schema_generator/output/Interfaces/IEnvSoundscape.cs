using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvSoundscape : IBaseEntity {

  
  public IEntityIOOutput OnPlay { get; }
  
  public ref float Radius { get; }
  
  public ref CUtlSymbolLarge SoundEventName { get; }
  
  public ref bool OverrideWithEvent { get; }
  
  public ref int SoundscapeIndex { get; }
  
  public ref int SoundscapeEntityListId { get; }
  
  public ISchemaFixedArray<CUtlSymbolLarge> PositionNames { get; }
  
  public ref CHandle<CEnvSoundscape> ProxySoundscape { get; }
  
  public ref bool Disabled { get; }
  
  public ref CUtlSymbolLarge SoundscapeName { get; }
  
  public ref uint SoundEventHash { get; }
}