using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptTriggerMultiple : ITriggerMultiple {

  public ref Vector Extent { get; }
  
}