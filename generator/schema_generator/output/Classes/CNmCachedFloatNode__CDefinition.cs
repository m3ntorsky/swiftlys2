using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmCachedFloatNode__CDefinition : CNmFloatValueNode::CDefinition, INmCachedFloatNode__CDefinition {

  public CNmCachedFloatNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmCachedFloatNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x3390BC2F95E89F27));
  }
  public ref NmCachedValueMode_t Mode {
    get => ref _Handle.AsRef<NmCachedValueMode_t>(Schema.GetOffset(0x3390BC2F90FD5BB2));
  }


}