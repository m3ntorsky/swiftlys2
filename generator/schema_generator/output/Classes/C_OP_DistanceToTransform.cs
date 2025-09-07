using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DistanceToTransform : CParticleFunctionOperator, IC_OP_DistanceToTransform {

  public C_OP_DistanceToTransform(nint handle) : base(handle) {
  }

  public C_OP_DistanceToTransform(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4E442549E5729606));
  }
  public IPerParticleFloatInput InputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4E442549E88A0D0F));
  }
  public IPerParticleFloatInput InputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4E442549D6766901));
  }
  public IPerParticleFloatInput OutputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4E4425495F8D7716));
  }
  public IPerParticleFloatInput OutputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4E44254951A0E8C4));
  }
  public IParticleTransformInput TransformStart {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x4E442549D94FA7F9));
  }
  public ref bool LOS {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4E4425499C25C2ED));
  }
  public ISchemaFixedString CollisionGroupName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x4E442549D58A3195));
  }
  public ref ParticleTraceSet_t TraceSet {
    get => ref _Handle.AsRef<ParticleTraceSet_t>(Schema.GetOffset(0x4E442549BD26C5B2));
  }
  public ref float MaxTraceLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4E442549543C3798));
  }
  public ref float LOSScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4E442549259F6F3B));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x4E442549FB53C31E));
  }
  public ref bool ActiveRange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4E4425493FA53B84));
  }
  public ref bool Additive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4E4425490FA86105));
  }
  public IPerParticleVecInput ComponentScale {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x4E442549B17954E2));
  }


}