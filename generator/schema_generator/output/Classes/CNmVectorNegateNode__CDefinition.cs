using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVectorNegateNode__CDefinition : CNmVectorValueNode::CDefinition, INmVectorNegateNode__CDefinition {

  public CNmVectorNegateNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmVectorNegateNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xAC99508E95E89F27));
  }


}