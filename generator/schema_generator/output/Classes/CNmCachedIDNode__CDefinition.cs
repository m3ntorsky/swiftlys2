using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmCachedIDNode__CDefinition : CNmIDValueNode::CDefinition, INmCachedIDNode__CDefinition {

  public CNmCachedIDNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9527FDE895E89F27));
  }
  public ref NmCachedValueMode_t Mode {
    get => ref _Handle.AsRef<NmCachedValueMode_t>(Schema.GetOffset(0x9527FDE890FD5BB2));
  }


}