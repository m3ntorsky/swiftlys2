using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerSwitch : IVoiceContainerBase {

  
// CUtlVector< CSoundContainerReference >
  public ref CUtlVector SoundsToPlay { get; }
}