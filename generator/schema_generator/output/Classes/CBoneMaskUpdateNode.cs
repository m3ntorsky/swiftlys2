using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneMaskUpdateNode : CBinaryUpdateNode, IBoneMaskUpdateNode {

  public CBoneMaskUpdateNode(nint handle) : base(handle) {
  }

  public ref int WeightListIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x213CBA4D30288377));
  }
  public ref float RootMotionBlend {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x213CBA4DAF24631C));
  }
  public ref BoneMaskBlendSpace BlendSpace {
    get => ref _Handle.AsRef<BoneMaskBlendSpace>(Schema.GetOffset(0x213CBA4D9DCBC41E));
  }
  public ref BinaryNodeChildOption FootMotionTiming {
    get => ref _Handle.AsRef<BinaryNodeChildOption>(Schema.GetOffset(0x213CBA4DBB17F13D));
  }
  public ref bool UseBlendScale {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x213CBA4DF5B40057));
  }
  public ref AnimValueSource BlendValueSource {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0x213CBA4D7AB7C374));
  }
  public IAnimParamHandle BlendParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x213CBA4D40990659));
  }


}