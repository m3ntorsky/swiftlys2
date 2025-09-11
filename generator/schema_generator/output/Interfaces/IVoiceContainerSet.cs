using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerSet : IVoiceContainerBase {

  
// CUtlVector< CVoiceContainerSetElement >
  public ref CUtlVector SoundsToPlay { get; }
}