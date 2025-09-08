using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDirectPlaybackUpdateNode : IUnaryUpdateNode {

  public ref bool FinishEarly { get; }
  
  public ref bool ResetOnFinish { get; }
  
  public ref CUtlVector AllTags { get; }
  
}