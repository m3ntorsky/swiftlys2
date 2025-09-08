using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfig : ISchemaClass {

  public ref CUtlString ConfigName { get; }
  
  public ref CUtlVector<PointerTo<CModelConfigElement>> Elements { get; }
  
  public ref bool TopLevel { get; }
  
  public ref bool ActiveInEditorByDefault { get; }
  
}