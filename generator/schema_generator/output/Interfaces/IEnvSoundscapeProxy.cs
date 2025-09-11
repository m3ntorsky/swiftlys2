using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvSoundscapeProxy : IEnvSoundscape {

  
  public ref CUtlSymbolLarge MainSoundscapeName { get; }
}