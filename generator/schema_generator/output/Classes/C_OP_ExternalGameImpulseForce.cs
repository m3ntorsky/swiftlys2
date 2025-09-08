using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ExternalGameImpulseForce : CParticleFunctionForce, IC_OP_ExternalGameImpulseForce {

  public C_OP_ExternalGameImpulseForce(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput ForceScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9579EDD64817F390));
  }
  public ref bool Ropes {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9579EDD63A651EDA));
  }
  public ref bool RopesZOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9579EDD686709BB2));
  }
  public ref bool Explosions {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9579EDD64CD39BC9));
  }
  public ref bool Particles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9579EDD6B287A104));
  }


}