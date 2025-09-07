using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmCachedVectorNode__CDefinition : CNmVectorValueNode::CDefinition, INmCachedVectorNode__CDefinition {

  public CNmCachedVectorNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmCachedVectorNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x4F6FE2EA95E89F27));
  }
  public ref NmCachedValueMode_t Mode {
    get => ref _Handle.AsRef<NmCachedValueMode_t>(Schema.GetOffset(0x4F6FE2EA90FD5BB2));
  }


}