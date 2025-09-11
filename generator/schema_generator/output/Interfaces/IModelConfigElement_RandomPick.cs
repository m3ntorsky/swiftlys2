using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement_RandomPick : IModelConfigElement {

  
  public ref CUtlVector<CUtlString> Choices { get; }
  
  public ref CUtlVector<float> ChoiceWeights { get; }
}