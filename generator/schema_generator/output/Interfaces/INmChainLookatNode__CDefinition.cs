using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmChainLookatNode__CDefinition : INmPassthroughNode::CDefinition {

  
  public ref CGlobalSymbol ChainEndBoneID { get; }
  
  public ref short LookatTargetNodeIdx { get; }
  
  public ref short EnabledNodeIdx { get; }
  
  public ref float BlendTimeSeconds { get; }
  
  public ref byte ChainLength { get; }
  
  public ref bool IsTargetInWorldSpace { get; }
  
  public ref Vector ChainForwardDir { get; }
}