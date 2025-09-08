using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FootPinningPoseOpFixedData_t : SchemaClass, IFootPinningPoseOpFixedData_t {

  public FootPinningPoseOpFixedData_t(nint handle) : base(handle) {
  }

  public ref CUtlVector FootInfo {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x87C487AD942F50C1));
  }
  public ref float BlendTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x87C487ADA6206E9F));
  }
  public ref float LockBreakDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x87C487AD71965CA0));
  }
  public ref float MaxLegTwist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x87C487ADB79440DC));
  }
  public ref int HipBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x87C487AD12FFBC70));
  }
  public ref bool ApplyLegTwistLimits {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x87C487AD95B3EE60));
  }
  public ref bool ApplyFootRotationLimits {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x87C487AD7C3F5AED));
  }


}