using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmBoneMaskBlendNode__CDefinition : CNmBoneMaskValueNode::CDefinition, INmBoneMaskBlendNode__CDefinition {

  public CNmBoneMaskBlendNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmBoneMaskBlendNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceMaskNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x551EA0BCFF243A47));
  }
  public ref short TargetMaskNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x551EA0BC74E90A6F));
  }
  public ref short BlendWeightValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x551EA0BC2735A990));
  }


}