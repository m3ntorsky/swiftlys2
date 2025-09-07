using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFixedWeightBoneMaskNode__CDefinition : CNmBoneMaskValueNode::CDefinition, INmFixedWeightBoneMaskNode__CDefinition {

  public CNmFixedWeightBoneMaskNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFixedWeightBoneMaskNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float BoneWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x26E0BD7363DE76E9));
  }


}