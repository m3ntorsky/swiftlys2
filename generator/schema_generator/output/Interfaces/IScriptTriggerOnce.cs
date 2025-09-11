using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptTriggerOnce : ITriggerOnce {

  
  public ref Vector Extent { get; }
}