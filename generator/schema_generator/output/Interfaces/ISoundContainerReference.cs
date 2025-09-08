using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundContainerReference : ISchemaClass {

  public ref bool UseReference { get; }
  
  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> Sound { get; }
  
  public IVoiceContainerBase Sound { get; }
  
}