using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement_SetBodygroupOnAttachedModels : IModelConfigElement {

  public ref CUtlString GroupName { get; }
  
  public ref int Choice { get; }
  
}