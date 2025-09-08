using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement_UserPick : IModelConfigElement {

  public ref CUtlVector<CUtlString> Choices { get; }
  
}