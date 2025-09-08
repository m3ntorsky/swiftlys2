using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFollowBoneNode__CDefinition : INmPassthroughNode::CDefinition {

  public ref CGlobalSymbol Bone { get; }
  
  public ref CGlobalSymbol FollowTargetBone { get; }
  
  public ref short EnabledNodeIdx { get; }
  
  public ref NmFollowBoneMode_t Mode { get; }
  
}