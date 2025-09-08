using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ScreenSpacePositionOfTarget : CParticleFunctionOperator, IC_OP_ScreenSpacePositionOfTarget {

  public C_OP_ScreenSpacePositionOfTarget(nint handle) : base(handle) {
  }

  public IPerParticleVecInput TargetPosition {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x5FF537BA554C563B));
  }
  public ref bool OututBehindness {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5FF537BADB123D49));
  }
  public IParticleAttributeIndex_t BehindFieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5FF537BA69F4F392));
  }
  public IParticleRemapFloatInput BehindOutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x5FF537BA4B35FBF3));
  }
  public ref ParticleSetMethod_t BehindSetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x5FF537BAFE7A7BDA));
  }


}