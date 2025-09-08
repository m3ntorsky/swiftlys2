using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITestBlendContainer : IVoiceContainerBase {

  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> FirstSound { get; }
  
  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> SecondSound { get; }
  
}