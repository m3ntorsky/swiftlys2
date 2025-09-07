using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVirtualParameterIDNode__CDefinition : CNmIDValueNode::CDefinition, INmVirtualParameterIDNode__CDefinition {

  public CNmVirtualParameterIDNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmVirtualParameterIDNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE010C6705C29A73C));
  }


}