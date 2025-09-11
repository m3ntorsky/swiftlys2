using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoDynamicShadowHintBox : IInfoDynamicShadowHint {

  
  public ref Vector BoxMins { get; }
  
  public ref Vector BoxMaxs { get; }
}