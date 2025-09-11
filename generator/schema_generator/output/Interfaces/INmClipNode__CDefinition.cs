using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmClipNode__CDefinition : INmClipReferenceNode::CDefinition {

  
  public ref short PlayInReverseValueNodeIdx { get; }
  
  public ref short ResetTimeValueNodeIdx { get; }
  
  public ref float SpeedMultiplier { get; }
  
  public ref int StartSyncEventOffset { get; }
  
  public ref bool SampleRootMotion { get; }
  
  public ref bool AllowLooping { get; }
  
  public ref short DataSlotIdx { get; }
}