using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmStateMachineNode__CDefinition : CNmPoseNode::CDefinition, INmStateMachineNode__CDefinition {

  public CNmStateMachineNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmStateMachineNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlLeanVectorFixedGrowable< CNmStateMachineNode::StateDefinition_t, 5 > StateDefinitions {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< CNmStateMachineNode::StateDefinition_t, 5 >>(Schema.GetOffset(0xA73F392775230B54));
  }
  public ref short DefaultStateIndex {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA73F39276C1EC5ED));
  }


}