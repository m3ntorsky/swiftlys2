using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerBlender : IVoiceContainerBase {

  public ISoundContainerReference FirstSound { get; }
  
  public ISoundContainerReference SecondSound { get; }
  
  public ref float BlendFactor { get; }
  
}