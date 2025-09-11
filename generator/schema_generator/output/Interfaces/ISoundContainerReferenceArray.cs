using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundContainerReferenceArray : ISchemaClass {

  
  public ref bool UseReference { get; }
  
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCVoiceContainerBase>> Sounds { get; }
  
  public ref CUtlVector<PointerTo<CVoiceContainerBase>> Sounds { get; }
}