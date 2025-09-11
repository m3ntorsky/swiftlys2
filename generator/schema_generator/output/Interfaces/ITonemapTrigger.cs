using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITonemapTrigger : IBaseTrigger {

  
  public ref CUtlSymbolLarge TonemapControllerName { get; }
  
  public ref CEntityHandle TonemapController { get; }
}