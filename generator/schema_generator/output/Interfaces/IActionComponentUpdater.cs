using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IActionComponentUpdater : IAnimComponentUpdater {

  public ref CUtlVector Actions { get; }
  
}