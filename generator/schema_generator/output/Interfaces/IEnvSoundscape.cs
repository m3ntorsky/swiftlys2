using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvSoundscape : IBaseEntity {

  
  public IEntityIOOutput OnPlay { get; }
  
  public ref float Radius { get; }
  
  public ISchemaUntypedField SoundEventName { get; }
  
  public ref bool OverrideWithEvent { get; }
  
  public ref int SoundscapeIndex { get; }
  
  public ref int SoundscapeEntityListId { get; }
  
  public ISchemaUntypedField PositionNames { get; }
  
  public ref CHandle<CEnvSoundscape> ProxySoundscape { get; }
  
  public ref bool Disabled { get; }
  
  public ISchemaUntypedField SoundscapeName { get; }
  
  public ref uint SoundEventHash { get; }
}