using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CollideWithParentParticles : CParticleFunctionConstraint, IC_OP_CollideWithParentParticles {

  public C_OP_CollideWithParentParticles(nint handle) : base(handle) {
  }

  public C_OP_CollideWithParentParticles(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput ParentRadiusScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x73030DD0CD77EF69));
  }
  public IPerParticleFloatInput RadiusScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x73030DD0A7A20159));
  }


}