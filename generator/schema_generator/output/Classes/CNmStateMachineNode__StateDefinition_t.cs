using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmStateMachineNode__StateDefinition_t : SchemaClass, INmStateMachineNode__StateDefinition_t {

  public CNmStateMachineNode__StateDefinition_t(nint handle) : base(handle) {
  }

  public CNmStateMachineNode__StateDefinition_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short StateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x539BB818074CB7A1));
  }
  public ref short EntryConditionNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x539BB8180B262993));
  }
  public ref CUtlLeanVectorFixedGrowable< CNmStateMachineNode::TransitionDefinition_t, 5 > TransitionDefinitions {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< CNmStateMachineNode::TransitionDefinition_t, 5 >>(Schema.GetOffset(0x539BB818F02EF580));
  }


}