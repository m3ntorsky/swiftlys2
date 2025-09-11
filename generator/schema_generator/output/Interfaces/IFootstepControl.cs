using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootstepControl : IBaseTrigger {

  
  public ref CUtlSymbolLarge Source { get; }
  
  public ref CUtlSymbolLarge Destination { get; }
}