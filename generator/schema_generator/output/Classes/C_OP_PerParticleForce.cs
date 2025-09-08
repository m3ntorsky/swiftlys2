using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PerParticleForce : CParticleFunctionForce, IC_OP_PerParticleForce {

  public C_OP_PerParticleForce(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput ForceScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x70EFAEAD4817F390));
  }
  public IPerParticleVecInput Force {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x70EFAEADE530B0A8));
  }
  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x70EFAEADEB661472));
  }


}