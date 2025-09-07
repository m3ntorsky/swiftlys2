using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitialVelocityNoise : CParticleFunctionInitializer, IC_INIT_InitialVelocityNoise {

  public C_INIT_InitialVelocityNoise(nint handle) : base(handle) {
  }

  public C_INIT_InitialVelocityNoise(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector AbsVal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4F8B7A615311700A));
  }
  public ref Vector AbsValInv {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4F8B7A611ED9F679));
  }
  public IPerParticleVecInput OffsetLoc {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x4F8B7A61EFAB26AC));
  }
  public IPerParticleFloatInput Offset {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4F8B7A617F14BA34));
  }
  public IPerParticleVecInput OutputMin {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x4F8B7A612EFED678));
  }
  public IPerParticleVecInput OutputMax {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x4F8B7A61451280D2));
  }
  public IPerParticleFloatInput NoiseScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4F8B7A6132FE2EF3));
  }
  public IPerParticleFloatInput NoiseScaleLoc {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4F8B7A61A9F4B0DF));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x4F8B7A61B3FDC289));
  }
  public ref bool IgnoreDt {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4F8B7A61330C0603));
  }


}