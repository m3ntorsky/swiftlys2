using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmPassthroughNode__CDefinition : CNmPoseNode::CDefinition, INmPassthroughNode__CDefinition {

  public CNmPassthroughNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x989A91ED5C29A73C));
  }


}