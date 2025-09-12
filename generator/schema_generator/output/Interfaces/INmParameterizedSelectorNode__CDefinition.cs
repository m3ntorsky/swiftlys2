using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmParameterizedSelectorNode__CDefinition : INmPoseNode::CDefinition {

  
  public ISchemaUntypedField OptionNodeIndices { get; }
  
  public ISchemaUntypedField OptionWeights { get; }
  
  public ref short ParameterNodeIdx { get; }
  
  public ref bool IgnoreInvalidOptions { get; }
  
  public ref bool HasWeightsSet { get; }
}