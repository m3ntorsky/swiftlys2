using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_ScreenSpacePositionOfTarget : CParticleFunctionInitializer, IC_INIT_ScreenSpacePositionOfTarget {

  public C_INIT_ScreenSpacePositionOfTarget(nint handle) : base(handle) {
  }

  public C_INIT_ScreenSpacePositionOfTarget(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleVecInput TargetPosition {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xBA53E3F7554C563B));
  }
  public ref bool OututBehindness {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBA53E3F7DB123D49));
  }
  public IParticleAttributeIndex_t BehindFieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xBA53E3F769F4F392));
  }
  public IParticleRemapFloatInput BehindOutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0xBA53E3F74B35FBF3));
  }


}