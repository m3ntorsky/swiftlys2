using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmBlend2DNode__CDefinition : INmPoseNode::CDefinition {

  
  public ref CUtlVectorFixedGrowable<short> SourceNodeIndices { get; }
  
  public ref short InputParameterNodeIdx0 { get; }
  
  public ref short InputParameterNodeIdx1 { get; }
  
  public ref CUtlVectorFixedGrowable<Vector2D> Values { get; }
  
  public ref CUtlVectorFixedGrowable<byte> Indices { get; }
  
  public ref CUtlVectorFixedGrowable<byte> HullIndices { get; }
  
  public ref bool AllowLooping { get; }
}