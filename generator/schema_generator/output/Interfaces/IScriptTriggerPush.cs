using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptTriggerPush : ITriggerPush {

  public ref Vector Extent { get; }
  
}