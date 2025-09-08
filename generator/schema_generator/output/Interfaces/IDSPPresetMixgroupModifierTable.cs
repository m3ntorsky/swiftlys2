using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDSPPresetMixgroupModifierTable : ISchemaClass {

  public ref CUtlVector Table { get; }
  
}