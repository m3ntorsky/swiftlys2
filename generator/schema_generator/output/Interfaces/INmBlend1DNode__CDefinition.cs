using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmBlend1DNode__CDefinition : INmParameterizedBlendNode::CDefinition {

  public INmParameterizedBlendNode::Parameterization_t Parameterization { get; }
  
}