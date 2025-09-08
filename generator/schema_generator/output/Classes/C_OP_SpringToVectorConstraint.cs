using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SpringToVectorConstraint : CParticleFunctionConstraint, IC_OP_SpringToVectorConstraint {

  public C_OP_SpringToVectorConstraint(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput RestLength {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF442244193AC4079));
  }
  public IPerParticleFloatInput MinDistance {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF442244192BCAD06));
  }
  public IPerParticleFloatInput MaxDistance {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF442244198893360));
  }
  public IPerParticleFloatInput RestingLength {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF4422441BB988EAF));
  }
  public IPerParticleVecInput AnchorVector {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xF442244180D613F3));
  }


}