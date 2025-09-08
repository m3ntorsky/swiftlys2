using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FootLockPoseOpFixedSettings : SchemaClass, IFootLockPoseOpFixedSettings {

  public FootLockPoseOpFixedSettings(nint handle) : base(handle) {
  }

  public ref CUtlVector FootInfo {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1246AD6B942F50C1));
  }
  public IAnimInputDamping HipDampingSettings {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0x1246AD6B3453D635));
  }
  public ref int HipBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1246AD6B12FFBC70));
  }
  public ref IKSolverType IkSolverType {
    get => ref _Handle.AsRef<IKSolverType>(Schema.GetOffset(0x1246AD6BDD30189E));
  }
  public ref bool ApplyTilt {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1246AD6B4568146C));
  }
  public ref bool ApplyHipDrop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1246AD6B3905DD5D));
  }
  public ref bool AlwaysUseFallbackHinge {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1246AD6B58B8E174));
  }
  public ref bool ApplyFootRotationLimits {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1246AD6B7C3F5AED));
  }
  public ref bool ApplyLegTwistLimits {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1246AD6B95B3EE60));
  }
  public ref float MaxFootHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1246AD6B42AF5050));
  }
  public ref float ExtensionScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1246AD6B4059BBBA));
  }
  public ref float MaxLegTwist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1246AD6BB79440DC));
  }
  public ref bool EnableLockBreaking {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1246AD6BEC9BF16C));
  }
  public ref float LockBreakTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1246AD6BC7586E26));
  }
  public ref float LockBlendTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1246AD6B91AE988A));
  }
  public ref bool EnableStretching {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1246AD6BE2E75A5D));
  }
  public ref float MaxStretchAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1246AD6B18F00468));
  }
  public ref float StretchExtensionScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1246AD6BE711A7A5));
  }


}