using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVirtualParameterFloatNode__CDefinition : CNmFloatValueNode::CDefinition, INmVirtualParameterFloatNode__CDefinition {

  public CNmVirtualParameterFloatNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmVirtualParameterFloatNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x29E3EB575C29A73C));
  }


}