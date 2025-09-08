using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmOrientationWarpNode__CDefinition : CNmPoseNode::CDefinition, INmOrientationWarpNode__CDefinition {

  public CNmOrientationWarpNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short ClipReferenceNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1265525761EC8947));
  }
  public ref short TargetValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x12655257A040C7E8));
  }
  public ref bool IsOffsetNode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x12655257174AF9D6));
  }
  public ref bool IsOffsetRelativeToCharacter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1265525793271816));
  }
  public ref CNmRootMotionData::SamplingMode_t SamplingMode {
    get => ref _Handle.AsRef<CNmRootMotionData::SamplingMode_t>(Schema.GetOffset(0x12655257DDB31BE3));
  }


}