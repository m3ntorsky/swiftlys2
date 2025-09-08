using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTargetInfoNode__CDefinition : CNmFloatValueNode::CDefinition, INmTargetInfoNode__CDefinition {

  public CNmTargetInfoNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x2288EABA95E89F27));
  }
  public ref CNmTargetInfoNode::Info_t InfoType {
    get => ref _Handle.AsRef<CNmTargetInfoNode::Info_t>(Schema.GetOffset(0x2288EABACE6BA20D));
  }
  public ref bool IsWorldSpaceTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2288EABAB81D53F2));
  }


}