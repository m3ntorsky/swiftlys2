using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTargetOffsetNode__CDefinition : CNmTargetValueNode::CDefinition, INmTargetOffsetNode__CDefinition {

  public CNmTargetOffsetNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x33F484EF95E89F27));
  }
  public ref bool IsBoneSpaceOffset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x33F484EF7B33F588));
  }
  public ref Quaternion RotationOffset {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x33F484EFD70314A4));
  }
  public ref Vector TranslationOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x33F484EF1ABA9777));
  }


}