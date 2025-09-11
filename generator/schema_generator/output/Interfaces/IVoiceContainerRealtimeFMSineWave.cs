using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerRealtimeFMSineWave : IVoiceContainerBase {

  
  public ref float CarrierFrequency { get; }
  
  public ref float ModulatorFrequency { get; }
  
  public ref float ModulatorAmount { get; }
}