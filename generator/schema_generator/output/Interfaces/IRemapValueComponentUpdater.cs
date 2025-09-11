using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRemapValueComponentUpdater : IAnimComponentUpdater {

  
// CUtlVector< CRemapValueUpdateItem >
  public ref CUtlVector Items { get; }
}