using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventMetaData : ISchemaClass {

  public ref CStrongHandle<InfoForResourceTypeCVMixListResource> SoundEventVMix { get; }
  
}