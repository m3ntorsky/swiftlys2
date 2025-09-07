using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DistanceBetweenTransforms : CParticleFunctionOperator, IC_OP_DistanceBetweenTransforms {

  public C_OP_DistanceBetweenTransforms(nint handle) : base(handle) {
  }

  public C_OP_DistanceBetweenTransforms(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x60A44933E5729606));
  }
  public IParticleTransformInput TransformStart {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x60A44933D94FA7F9));
  }
  public IParticleTransformInput TransformEnd {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x60A449330C3277C8));
  }
  public IPerParticleFloatInput InputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x60A44933E88A0D0F));
  }
  public IPerParticleFloatInput InputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x60A44933D6766901));
  }
  public IPerParticleFloatInput OutputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x60A449335F8D7716));
  }
  public IPerParticleFloatInput OutputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x60A4493351A0E8C4));
  }
  public ref float MaxTraceLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x60A44933543C3798));
  }
  public ref float LOSScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x60A44933259F6F3B));
  }
  public ISchemaFixedString CollisionGroupName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x60A44933D58A3195));
  }
  public ref ParticleTraceSet_t TraceSet {
    get => ref _Handle.AsRef<ParticleTraceSet_t>(Schema.GetOffset(0x60A44933BD26C5B2));
  }
  public ref bool LOS {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x60A449339C25C2ED));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x60A44933FB53C31E));
  }


}