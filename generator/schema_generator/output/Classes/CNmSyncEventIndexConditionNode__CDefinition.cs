using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSyncEventIndexConditionNode__CDefinition : CNmBoolValueNode::CDefinition, INmSyncEventIndexConditionNode__CDefinition {

  public CNmSyncEventIndexConditionNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmSyncEventIndexConditionNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x343CD5DB63F0228C));
  }
  public ref CNmSyncEventIndexConditionNode::TriggerMode_t TriggerMode {
    get => ref _Handle.AsRef<CNmSyncEventIndexConditionNode::TriggerMode_t>(Schema.GetOffset(0x343CD5DB0431A60C));
  }
  public ref int SyncEventIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x343CD5DBC84F66C9));
  }


}