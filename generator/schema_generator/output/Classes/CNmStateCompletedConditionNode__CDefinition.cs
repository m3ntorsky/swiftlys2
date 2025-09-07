using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmStateCompletedConditionNode__CDefinition : CNmBoolValueNode::CDefinition, INmStateCompletedConditionNode__CDefinition {

  public CNmStateCompletedConditionNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmStateCompletedConditionNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x4C5A15CA63F0228C));
  }
  public ref short TransitionDurationOverrideNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x4C5A15CACD97BBA1));
  }
  public ref float TransitionDurationSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C5A15CAD5E92B1D));
  }


}