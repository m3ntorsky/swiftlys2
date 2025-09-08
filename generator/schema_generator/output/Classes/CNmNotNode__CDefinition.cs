using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmNotNode__CDefinition : CNmBoolValueNode::CDefinition, INmNotNode__CDefinition {

  public CNmNotNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x844BE2B095E89F27));
  }


}