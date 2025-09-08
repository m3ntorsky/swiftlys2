using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatRemapNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatRemapNode__CDefinition {

  public CNmFloatRemapNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x5169293495E89F27));
  }
  public INmFloatRemapNode::RemapRange_t InputRange {
    get => new CNmFloatRemapNode::RemapRange_t(_Handle + Schema.GetOffset(0x51692934096AEBF0));
  }
  public INmFloatRemapNode::RemapRange_t OutputRange {
    get => new CNmFloatRemapNode::RemapRange_t(_Handle + Schema.GetOffset(0x5169293437E0CA29));
  }


}