using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVirtualParameterBoolNode__CDefinition : CNmBoolValueNode::CDefinition, INmVirtualParameterBoolNode__CDefinition {

  public CNmVirtualParameterBoolNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA28816AF5C29A73C));
  }


}