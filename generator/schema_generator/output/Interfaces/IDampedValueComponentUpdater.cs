using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDampedValueComponentUpdater : IAnimComponentUpdater {

  
// CUtlVector< CDampedValueUpdateItem >
  public ref CUtlVector Items { get; }
}