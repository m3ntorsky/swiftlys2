using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTargetPointNode__CDefinition : CNmVectorValueNode::CDefinition, INmTargetPointNode__CDefinition {

  public CNmTargetPointNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmTargetPointNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xCF5C70C495E89F27));
  }
  public ref bool IsWorldSpaceTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCF5C70C4B81D53F2));
  }


}