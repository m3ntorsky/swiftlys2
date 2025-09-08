using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmReferencedGraphNode__CDefinition : CNmPoseNode::CDefinition, INmReferencedGraphNode__CDefinition {

  public CNmReferencedGraphNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short ReferencedGraphIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x44045ED427B00199));
  }
  public ref short FallbackNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x44045ED4AFA8F89E));
  }


}