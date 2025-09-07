using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CurlNoiseForce : CParticleFunctionForce, IC_OP_CurlNoiseForce {

  public C_OP_CurlNoiseForce(nint handle) : base(handle) {
  }

  public C_OP_CurlNoiseForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ParticleDirectionNoiseType_t NoiseType {
    get => ref _Handle.AsRef<ParticleDirectionNoiseType_t>(Schema.GetOffset(0xC8D644B26758ED35));
  }
  public IPerParticleVecInput NoiseFreq {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xC8D644B20A299A63));
  }
  public IPerParticleVecInput NoiseScale {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xC8D644B29CE92E45));
  }
  public IPerParticleVecInput Offset {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xC8D644B2BD25CC2A));
  }
  public IPerParticleVecInput OffsetRate {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xC8D644B23D58FFB8));
  }
  public IPerParticleFloatInput WorleySeed {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xC8D644B2D6881198));
  }
  public IPerParticleFloatInput WorleyJitter {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xC8D644B2C7509CCF));
  }


}