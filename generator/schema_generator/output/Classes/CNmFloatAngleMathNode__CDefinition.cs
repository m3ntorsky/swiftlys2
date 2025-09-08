using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatAngleMathNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatAngleMathNode__CDefinition {

  public CNmFloatAngleMathNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x464A924095E89F27));
  }
  public ref CNmFloatAngleMathNode::Operation_t Operation {
    get => ref _Handle.AsRef<CNmFloatAngleMathNode::Operation_t>(Schema.GetOffset(0x464A9240AEA59026));
  }


}