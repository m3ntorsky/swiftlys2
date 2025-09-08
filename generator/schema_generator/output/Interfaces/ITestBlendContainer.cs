using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITestBlendContainer : IVoiceContainerBase {

  public ref CStrongHandle<InfoForResourceTypeCVoiceContainerBase> FirstSound { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCVoiceContainerBase> SecondSound { get; }
  
}