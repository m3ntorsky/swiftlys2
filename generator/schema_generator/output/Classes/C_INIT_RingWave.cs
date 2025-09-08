using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RingWave : CParticleFunctionInitializer, IC_INIT_RingWave {

  public C_INIT_RingWave(nint handle) : base(handle) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xA5DA0691B3FDC289));
  }
  public IParticleCollectionFloatInput ParticlesPerOrbit {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA5DA069184EA503F));
  }
  public IPerParticleFloatInput InitialRadius {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA5DA06918B8AAB8B));
  }
  public IPerParticleFloatInput Thickness {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA5DA0691DC7C1987));
  }
  public IPerParticleFloatInput InitialSpeedMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA5DA0691E36FD694));
  }
  public IPerParticleFloatInput InitialSpeedMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA5DA0691D184D4F6));
  }
  public IPerParticleFloatInput Roll {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA5DA069188F97A90));
  }
  public IPerParticleFloatInput Pitch {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA5DA06911CBA22DB));
  }
  public IPerParticleFloatInput Yaw {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA5DA0691B40C1E8A));
  }
  public ref bool EvenDistribution {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA5DA069184932067));
  }
  public ref bool XYVelocityOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA5DA0691A20CED5B));
  }


}