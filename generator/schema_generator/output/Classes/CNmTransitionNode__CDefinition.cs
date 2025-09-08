using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTransitionNode__CDefinition : CNmPoseNode::CDefinition, INmTransitionNode__CDefinition {

  public CNmTransitionNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short TargetStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x23B71EF8DE6A1B64));
  }
  public ref short DurationOverrideNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x23B71EF8435EE64C));
  }
  public ref short TimeOffsetOverrideNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x23B71EF87B4CE92E));
  }
  public ref short StartBoneMaskNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x23B71EF8EF270494));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x23B71EF8BC5E3BAB));
  }
  public INmPercent_t BoneMaskBlendInTimePercentage {
    get => new NmPercent_t(_Handle + Schema.GetOffset(0x23B71EF83CBCEB24));
  }
  public ref float TimeOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x23B71EF86F4EE629));
  }
  public INmBitFlags TransitionOptions {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0x23B71EF8875C9EAC));
  }
  public ref short TargetSyncIDNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x23B71EF8A952D9BD));
  }
  public ref NmEasingOperation_t BlendWeightEasing {
    get => ref _Handle.AsRef<NmEasingOperation_t>(Schema.GetOffset(0x23B71EF8E7454DC5));
  }
  public ref NmRootMotionBlendMode_t RootMotionBlend {
    get => ref _Handle.AsRef<NmRootMotionBlendMode_t>(Schema.GetOffset(0x23B71EF88DADB2AE));
  }


}