using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerSwitch : IVoiceContainerBase {

  public ref CUtlVector SoundsToPlay { get; }
  
}