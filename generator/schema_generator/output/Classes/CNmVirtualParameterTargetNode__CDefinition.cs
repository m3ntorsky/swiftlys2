using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVirtualParameterTargetNode__CDefinition : CNmTargetValueNode::CDefinition, INmVirtualParameterTargetNode__CDefinition {

  public CNmVirtualParameterTargetNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmVirtualParameterTargetNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xB17F7CE05C29A73C));
  }


}