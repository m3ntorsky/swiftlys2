using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDSPPresetMixgroupModifierTable : ISchemaClass {

  
// CUtlVector< CDspPresetModifierList >
  public ref CUtlVector Table { get; }
}