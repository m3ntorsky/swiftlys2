using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleMassCalculationParameters : SchemaClass, IParticleMassCalculationParameters {

  public CParticleMassCalculationParameters(nint handle) : base(handle) {
  }

  public ref ParticleMassMode_t MassMode {
    get => ref _Handle.AsRef<ParticleMassMode_t>(Schema.GetOffset(0xAA3341F9D5B6E412));
  }
  public IPerParticleFloatInput Radius {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xAA3341F95ACFC08D));
  }
  public IPerParticleFloatInput NominalRadius {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xAA3341F9B6692A73));
  }
  public IPerParticleFloatInput Scale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xAA3341F9B731A42F));
  }


}