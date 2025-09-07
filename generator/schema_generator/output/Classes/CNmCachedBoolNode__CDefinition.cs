using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmCachedBoolNode__CDefinition : CNmBoolValueNode::CDefinition, INmCachedBoolNode__CDefinition {

  public CNmCachedBoolNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmCachedBoolNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x4BFAE2E795E89F27));
  }
  public ref NmCachedValueMode_t Mode {
    get => ref _Handle.AsRef<NmCachedValueMode_t>(Schema.GetOffset(0x4BFAE2E790FD5BB2));
  }


}