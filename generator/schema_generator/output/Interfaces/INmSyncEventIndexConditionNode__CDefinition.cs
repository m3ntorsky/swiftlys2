using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSyncEventIndexConditionNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref short SourceStateNodeIdx { get; }
  
  public ref CNmSyncEventIndexConditionNode::TriggerMode_t TriggerMode { get; }
  
  public ref int SyncEventIdx { get; }
}