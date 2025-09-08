using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmParameterizedBlendNode__CDefinition : INmPoseNode::CDefinition {

  public ref CUtlVectorFixedGrowable<short> SourceNodeIndices { get; }
  
  public ref short InputParameterValueNodeIdx { get; }
  
  public ref bool AllowLooping { get; }
  
}