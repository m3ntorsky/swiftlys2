using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGenericConstraint : CPhysConstraint, IGenericConstraint {

  public CGenericConstraint(nint handle) : base(handle) {
  }

  public CGenericConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref JointMotion_t LinearMotionX {
    get => ref _Handle.AsRef<JointMotion_t>(Schema.GetOffset(0x1698284879962AA2));
  }
  public ref JointMotion_t LinearMotionY {
    get => ref _Handle.AsRef<JointMotion_t>(Schema.GetOffset(0x169828487A962C35));
  }
  public ref JointMotion_t LinearMotionZ {
    get => ref _Handle.AsRef<JointMotion_t>(Schema.GetOffset(0x169828487796277C));
  }
  public ref float LinearFrequencyX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848D427BA04));
  }
  public ref float LinearFrequencyY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848D527BB97));
  }
  public ref float LinearFrequencyZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848D627BD2A));
  }
  public ref float LinearDampingRatioX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848075BA1D5));
  }
  public ref float LinearDampingRatioY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848065BA042));
  }
  public ref float LinearDampingRatioZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848055B9EAF));
  }
  public ref float MaxLinearImpulseX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848DA6330BF));
  }
  public ref float MaxLinearImpulseY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848D9632F2C));
  }
  public ref float MaxLinearImpulseZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848DC6333E5));
  }
  public ref float BreakAfterTimeX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848D1BE25CB));
  }
  public ref float BreakAfterTimeY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848D0BE2438));
  }
  public ref float BreakAfterTimeZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848D3BE28F1));
  }
  public IGameTime_t BreakAfterTimeStartTimeX {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x169828480B0683A6));
  }
  public IGameTime_t BreakAfterTimeStartTimeY {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x169828480C068539));
  }
  public IGameTime_t BreakAfterTimeStartTimeZ {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1698284809068080));
  }
  public ref float BreakAfterTimeThresholdX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848EA81B5D4));
  }
  public ref float BreakAfterTimeThresholdY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848EB81B767));
  }
  public ref float BreakAfterTimeThresholdZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848EC81B8FA));
  }
  public ref float NotifyForceX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1698284842CA87EB));
  }
  public ref float NotifyForceY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1698284841CA8658));
  }
  public ref float NotifyForceZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1698284844CA8B11));
  }
  public ref float NotifyForceMinTimeX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828482CB94C2E));
  }
  public ref float NotifyForceMinTimeY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828482DB94DC1));
  }
  public ref float NotifyForceMinTimeZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828482AB94908));
  }
  public IGameTime_t NotifyForceLastTimeX {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x169828485B7371B4));
  }
  public IGameTime_t NotifyForceLastTimeY {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x169828485C737347));
  }
  public IGameTime_t NotifyForceLastTimeZ {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x169828485D7374DA));
  }
  public ref bool AxisNotifiedX {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x169828483F5088F4));
  }
  public ref bool AxisNotifiedY {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1698284840508A87));
  }
  public ref bool AxisNotifiedZ {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1698284841508C1A));
  }
  public ref JointMotion_t AngularMotionX {
    get => ref _Handle.AsRef<JointMotion_t>(Schema.GetOffset(0x16982848F5DC3335));
  }
  public ref JointMotion_t AngularMotionY {
    get => ref _Handle.AsRef<JointMotion_t>(Schema.GetOffset(0x16982848F4DC31A2));
  }
  public ref JointMotion_t AngularMotionZ {
    get => ref _Handle.AsRef<JointMotion_t>(Schema.GetOffset(0x16982848F3DC300F));
  }
  public ref float AngularFrequencyX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1698284874F93B19));
  }
  public ref float AngularFrequencyY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1698284873F93986));
  }
  public ref float AngularFrequencyZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1698284872F937F3));
  }
  public ref float AngularDampingRatioX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828486B71C0CE));
  }
  public ref float AngularDampingRatioY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828486C71C261));
  }
  public ref float AngularDampingRatioZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828486971BDA8));
  }
  public ref float MaxAngularImpulseX {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828489B259BC6));
  }
  public ref float MaxAngularImpulseY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x169828489C259D59));
  }
  public ref float MaxAngularImpulseZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16982848992598A0));
  }
  public IEntityIOOutput NotifyForceReachedX {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x169828486707AE55));
  }
  public IEntityIOOutput NotifyForceReachedY {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x169828486607ACC2));
  }
  public IEntityIOOutput NotifyForceReachedZ {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x169828486507AB2F));
  }


}