using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement : ISchemaClass {

  public ref CUtlString ElementName { get; }
  
  public ref CUtlVector<PointerTo<CModelConfigElement>> NestedElements { get; }
  
}