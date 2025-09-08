using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmLayerBlendNode__LayerDefinition_t : SchemaClass, INmLayerBlendNode__LayerDefinition_t {

  public CNmLayerBlendNode__LayerDefinition_t(nint handle) : base(handle) {
  }

  public ref short InputNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xB5F2C492B0A177F6));
  }
  public ref short WeightValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xB5F2C4924E4CD159));
  }
  public ref short BoneMaskValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xB5F2C49284E70B17));
  }
  public ref short RootMotionWeightValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xB5F2C492C355D4CF));
  }
  public ref bool IsSynchronized {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB5F2C492DCF1E06B));
  }
  public ref bool IgnoreEvents {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB5F2C4920E574CA6));
  }
  public ref bool IsStateMachineLayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB5F2C492EE48C9D0));
  }
  public ref NmPoseBlendMode_t BlendMode {
    get => ref _Handle.AsRef<NmPoseBlendMode_t>(Schema.GetOffset(0xB5F2C4928D5006AB));
  }


}