using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement_SetMaterialGroupOnAttachedModels : IModelConfigElement {

  public ref CUtlString MaterialGroupName { get; }
  
}