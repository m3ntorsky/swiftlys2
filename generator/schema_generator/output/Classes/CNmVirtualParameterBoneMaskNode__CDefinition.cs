using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVirtualParameterBoneMaskNode__CDefinition : CNmBoneMaskValueNode::CDefinition, INmVirtualParameterBoneMaskNode__CDefinition {

  public CNmVirtualParameterBoneMaskNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmVirtualParameterBoneMaskNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x4C267E9D5C29A73C));
  }


}