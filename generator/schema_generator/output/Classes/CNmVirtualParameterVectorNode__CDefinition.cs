using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVirtualParameterVectorNode__CDefinition : CNmVectorValueNode::CDefinition, INmVirtualParameterVectorNode__CDefinition {

  public CNmVirtualParameterVectorNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xDD34E2D25C29A73C));
  }


}