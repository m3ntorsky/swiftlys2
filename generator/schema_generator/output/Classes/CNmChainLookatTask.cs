using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmChainLookatTask : CNmPoseTask, INmChainLookatTask {

  public CNmChainLookatTask(nint handle) : base(handle) {
  }

  public ref int ChainEndBoneIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4021FFEBC513D7B8));
  }
  public ref int NumBonesInChain {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4021FFEBCAD2EB3E));
  }
  public ref Vector ChainForwardDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4021FFEB98A5355A));
  }
  public ref float BlendWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4021FFEBE5D6B9CE));
  }
  public ref float HorizontalAngleLimitDegrees {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4021FFEB0D028F1E));
  }
  public ref float VerticalAngleLimitDegrees {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4021FFEBC3214250));
  }
  public ref Vector LookatTarget {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4021FFEBBD59D4D6));
  }
  public ref bool IsTargetInWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4021FFEB5F56E0C5));
  }
  public ref bool IsRunningFromDeserializedData {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4021FFEB4791111D));
  }
  public ref float HorizontalAngleDegrees {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4021FFEB25C3867F));
  }
  public ref float VerticalAngleDegrees {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4021FFEBF1DC7205));
  }


}