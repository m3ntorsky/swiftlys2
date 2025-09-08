using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTargetOffsetNode__CDefinition : INmTargetValueNode::CDefinition {

  public ref short InputValueNodeIdx { get; }
  
  public ref bool IsBoneSpaceOffset { get; }
  
  public ref Quaternion RotationOffset { get; }
  
  public ref Vector TranslationOffset { get; }
  
}