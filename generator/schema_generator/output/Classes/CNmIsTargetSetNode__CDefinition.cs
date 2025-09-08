using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIsTargetSetNode__CDefinition : CNmBoolValueNode::CDefinition, INmIsTargetSetNode__CDefinition {

  public CNmIsTargetSetNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x27C85C3E95E89F27));
  }


}