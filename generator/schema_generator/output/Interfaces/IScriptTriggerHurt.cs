using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptTriggerHurt : ITriggerHurt {

  
  public ref Vector Extent { get; }
}