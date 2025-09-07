using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootLockUpdateNode : CUnaryUpdateNode, IFootLockUpdateNode {

  public CFootLockUpdateNode(nint handle) : base(handle) {
  }

  public CFootLockUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IFootLockPoseOpFixedSettings OpFixedSettings {
    get => new FootLockPoseOpFixedSettings(_Handle + Schema.GetOffset(0xA8F37E8E533AB09));
  }
  public ref CUtlVector< FootFixedSettings > FootSettings {
    get => ref _Handle.AsRef<CUtlVector< FootFixedSettings >>(Schema.GetOffset(0xA8F37E8A7F2ADE4));
  }
  public IAnimInputDamping HipShiftDamping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xA8F37E80EA57628));
  }
  public IAnimInputDamping RootHeightDamping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xA8F37E84DE10164));
  }
  public ref float StrideCurveScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E824E250E9));
  }
  public ref float StrideCurveLimitScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E8BE5E55F6));
  }
  public ref float StepHeightIncreaseScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E8AEFDE950));
  }
  public ref float StepHeightDecreaseScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E882893258));
  }
  public ref float HipShiftScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E847C1BE5A));
  }
  public ref float BlendTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E8A6206E9F));
  }
  public ref float MaxRootHeightOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E8C33AC7DF));
  }
  public ref float MinRootHeightOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E8D9B970B1));
  }
  public ref float TiltPlanePitchSpringStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E864893350));
  }
  public ref float TiltPlaneRollSpringStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8F37E8AD412E55));
  }
  public ref bool ApplyFootRotationLimits {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8F37E87C3F5AED));
  }
  public ref bool ApplyHipShift {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8F37E8DE90F994));
  }
  public ref bool ModulateStepHeight {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8F37E82412FFBF));
  }
  public ref bool ResetChild {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8F37E865CC88B6));
  }
  public ref bool EnableVerticalCurvedPaths {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8F37E80A18A0EB));
  }
  public ref bool EnableRootHeightDamping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8F37E802F42911));
  }


}