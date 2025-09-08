using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerSetElement : ISchemaClass {

  public ISoundContainerReference Sound { get; }
  
  public ref float VolumeDB { get; }
  
}