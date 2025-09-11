using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IActionComponentUpdater : IAnimComponentUpdater {

  
// CUtlVector< CSmartPtr< CAnimActionUpdater > >
  public ref CUtlVector Actions { get; }
}