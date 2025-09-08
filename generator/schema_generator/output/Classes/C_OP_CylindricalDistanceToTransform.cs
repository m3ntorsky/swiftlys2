using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CylindricalDistanceToTransform : CParticleFunctionOperator, IC_OP_CylindricalDistanceToTransform {

  public C_OP_CylindricalDistanceToTransform(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x3B99017E5729606));
  }
  public IPerParticleFloatInput InputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B99017E88A0D0F));
  }
  public IPerParticleFloatInput InputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B99017D6766901));
  }
  public IPerParticleFloatInput OutputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B990175F8D7716));
  }
  public IPerParticleFloatInput OutputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B9901751A0E8C4));
  }
  public IParticleTransformInput TransformStart {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x3B99017D94FA7F9));
  }
  public IParticleTransformInput TransformEnd {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x3B990170C3277C8));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x3B99017FB53C31E));
  }
  public ref bool ActiveRange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3B990173FA53B84));
  }
  public ref bool Additive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3B990170FA86105));
  }
  public ref bool Capsule {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3B99017F8D8D1AC));
  }


}