using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MoveToHitbox : CParticleFunctionOperator, IC_OP_MoveToHitbox {

  public C_OP_MoveToHitbox(nint handle) : base(handle) {
  }

  public C_OP_MoveToHitbox(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleModelInput ModelInput {
    get => new CParticleModelInput(_Handle + Schema.GetOffset(0x4ACEA8FFEB74120E));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x4ACEA8FF3A9ED669));
  }
  public ref float LifeTimeLerpStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ACEA8FFB9B0BE37));
  }
  public ref float LifeTimeLerpEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ACEA8FF3BE2C292));
  }
  public ref float PrevPosScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ACEA8FF46CED122));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x4ACEA8FF6A21BB0E));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4ACEA8FF10D1938B));
  }
  public ref HitboxLerpType_t LerpType {
    get => ref _Handle.AsRef<HitboxLerpType_t>(Schema.GetOffset(0x4ACEA8FF74114DCC));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4ACEA8FFCF55B987));
  }


}