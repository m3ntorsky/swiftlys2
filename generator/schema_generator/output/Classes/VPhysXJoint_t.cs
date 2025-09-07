using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VPhysXJoint_t : SchemaClass, IVPhysXJoint_t {

  public VPhysXJoint_t(nint handle) : base(handle) {
  }

  public VPhysXJoint_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort Type {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x336EF6EE18853D59));
  }
  public ref ushort Body1 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x336EF6EEAFA36950));
  }
  public ref ushort Body2 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x336EF6EEB2A36E09));
  }
  public ref ushort Flags {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x336EF6EECE6E9C28));
  }
  public ref CTransform Frame1 {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x336EF6EEAC118935));
  }
  public ref CTransform Frame2 {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x336EF6EEA911847C));
  }
  public ref bool EnableCollision {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EE1E5412CE));
  }
  public ref bool IsLinearConstraintDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EE83052497));
  }
  public ref bool IsAngularConstraintDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EE9A8810AE));
  }
  public ref bool EnableLinearLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EE706DAE52));
  }
  public IVPhysXRange_t LinearLimit {
    get => new VPhysXRange_t(_Handle + Schema.GetOffset(0x336EF6EE6B07DCE3));
  }
  public ref bool EnableLinearMotor {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EE97738F64));
  }
  public ref Vector LinearTargetVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x336EF6EE73CF8AE2));
  }
  public ref float MaxForce {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EEB637FDD2));
  }
  public ref bool EnableSwingLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EEDADAC14B));
  }
  public IVPhysXRange_t SwingLimit {
    get => new VPhysXRange_t(_Handle + Schema.GetOffset(0x336EF6EEB5B3FDD8));
  }
  public ref bool EnableTwistLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EE7DBEA570));
  }
  public IVPhysXRange_t TwistLimit {
    get => new VPhysXRange_t(_Handle + Schema.GetOffset(0x336EF6EE42713723));
  }
  public ref bool EnableAngularMotor {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x336EF6EEA68A4ADD));
  }
  public ref Vector AngularTargetVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x336EF6EE9FAD55DB));
  }
  public ref float MaxTorque {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE45444085));
  }
  public ref float LinearFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE2FE6B034));
  }
  public ref float LinearDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE82438FAF));
  }
  public ref float AngularFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE36D56C7B));
  }
  public ref float AngularDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE689E74E2));
  }
  public ref float Friction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE6F5FEBA1));
  }
  public ref float Elasticity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE4EC38DF6));
  }
  public ref float ElasticDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE66E6B750));
  }
  public ref float Plasticity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x336EF6EE5843D1D7));
  }
  public ref CUtlString Tag {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x336EF6EE218D8313));
  }


}