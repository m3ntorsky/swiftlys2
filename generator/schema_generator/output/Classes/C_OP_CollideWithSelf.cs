using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CollideWithSelf : CParticleFunctionConstraint, IC_OP_CollideWithSelf {

  public C_OP_CollideWithSelf(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput RadiusScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xEF46C0CBA7A20159));
  }
  public IPerParticleFloatInput MinimumSpeed {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xEF46C0CB2F9BEFCC));
  }


}