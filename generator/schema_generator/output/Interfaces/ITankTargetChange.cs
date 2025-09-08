using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITankTargetChange : IPointEntity {

  public ISchemaUntypedField NewTarget { get; }
  
  public ref CUtlSymbolLarge NewTargetName { get; }
  
}