using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVectorInfoNode__CDefinition : CNmFloatValueNode::CDefinition, INmVectorInfoNode__CDefinition {

  public CNmVectorInfoNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x80D82BB895E89F27));
  }
  public ref CNmVectorInfoNode::Info_t DesiredInfo {
    get => ref _Handle.AsRef<CNmVectorInfoNode::Info_t>(Schema.GetOffset(0x80D82BB838B16675));
  }


}