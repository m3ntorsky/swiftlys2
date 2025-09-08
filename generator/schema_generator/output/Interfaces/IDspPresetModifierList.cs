using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDspPresetModifierList : ISchemaClass {

  public ref CUtlString DspName { get; }
  
  public ref CUtlVector Modifiers { get; }
  
}