using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_VelocityRandom : CParticleFunctionInitializer, IC_INIT_VelocityRandom {

  public C_INIT_VelocityRandom(nint handle) : base(handle) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xFCCBA9E3F31A6BD));
  }
  public IPerParticleFloatInput SpeedMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xFCCBA9EB989E1F8));
  }
  public IPerParticleFloatInput SpeedMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xFCCBA9ECF9D8C52));
  }
  public IPerParticleVecInput LocalCoordinateSystemSpeedMin {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xFCCBA9EA4A0F1AE));
  }
  public IPerParticleVecInput LocalCoordinateSystemSpeedMax {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xFCCBA9E968D53EC));
  }
  public ref bool IgnoreDT {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCCBA9E530C3863));
  }
  public IRandomNumberGeneratorParameters RandomnessParameters {
    get => new CRandomNumberGeneratorParameters(_Handle + Schema.GetOffset(0xFCCBA9E7EDF50AD));
  }


}