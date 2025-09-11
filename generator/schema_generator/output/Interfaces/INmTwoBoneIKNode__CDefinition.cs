using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTwoBoneIKNode__CDefinition : INmPassthroughNode::CDefinition {

  
  public ref CGlobalSymbol EffectorBoneID { get; }
  
  public ref short EffectorTargetNodeIdx { get; }
  
  public ref short EnabledNodeIdx { get; }
  
  public ref float BlendTimeSeconds { get; }
  
  public ref NmIKBlendMode_t BlendMode { get; }
  
  public ref bool IsTargetInWorldSpace { get; }
}