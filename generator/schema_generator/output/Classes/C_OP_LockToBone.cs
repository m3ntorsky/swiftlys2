using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LockToBone : CParticleFunctionOperator, IC_OP_LockToBone {

  public C_OP_LockToBone(nint handle) : base(handle) {
  }

  public IParticleModelInput ModelInput {
    get => new CParticleModelInput(_Handle + Schema.GetOffset(0xF6C2B94DEB74120E));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xF6C2B94D3A9ED669));
  }
  public ref float LifeTimeFadeStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF6C2B94D95A2845A));
  }
  public ref float LifeTimeFadeEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF6C2B94D222841EF));
  }
  public ref float JumpThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF6C2B94DB6BB1AD6));
  }
  public ref float PrevPosScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF6C2B94D46CED122));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle, 0xF6C2B94D6A21BB0E, 128, 1, 1);
  }
  public ref bool Rigid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6C2B94DF9ED9C8C));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6C2B94D10D1938B));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF6C2B94DE5729606));
  }
  public IParticleAttributeIndex_t FieldOutputPrev {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF6C2B94D68D9463B));
  }
  public ref ParticleRotationLockType_t RotationSetType {
    get => ref _Handle.AsRef<ParticleRotationLockType_t>(Schema.GetOffset(0xF6C2B94D084883F9));
  }
  public ref bool RigidRotationLock {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6C2B94D824664C5));
  }
  public IPerParticleVecInput Rotation {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xF6C2B94D1992E6BF));
  }
  public IPerParticleFloatInput RotLerp {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF6C2B94D2C030C4D));
  }


}