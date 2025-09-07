using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateWithinSphereTransform : CParticleFunctionInitializer, IC_INIT_CreateWithinSphereTransform {

  public C_INIT_CreateWithinSphereTransform(nint handle) : base(handle) {
  }

  public C_INIT_CreateWithinSphereTransform(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput RadiusMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x97F9AC345AD00941));
  }
  public IPerParticleFloatInput RadiusMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x97F9AC344CE37AEF));
  }
  public IPerParticleVecInput DistanceBias {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x97F9AC34A7A33E17));
  }
  public ref Vector DistanceBiasAbs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x97F9AC34FCBB3E09));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x97F9AC34B3FDC289));
  }
  public IPerParticleFloatInput SpeedMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x97F9AC34B989E1F8));
  }
  public IPerParticleFloatInput SpeedMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x97F9AC34CF9D8C52));
  }
  public ref float SpeedRandExp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x97F9AC343303A1AA));
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x97F9AC3430E716DE));
  }
  public ref float EndCPGrowthTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x97F9AC34C156B981));
  }
  public IPerParticleVecInput LocalCoordinateSystemSpeedMin {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x97F9AC34A4A0F1AE));
  }
  public IPerParticleVecInput LocalCoordinateSystemSpeedMax {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x97F9AC34968D53EC));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x97F9AC34E5729606));
  }
  public IParticleAttributeIndex_t FieldVelocity {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x97F9AC34852EBFAC));
  }


}