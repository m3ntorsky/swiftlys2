using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ScreenSpaceRotateTowardTarget : CParticleFunctionOperator, IC_OP_ScreenSpaceRotateTowardTarget {

  public C_OP_ScreenSpaceRotateTowardTarget(nint handle) : base(handle) {
  }

  public C_OP_ScreenSpaceRotateTowardTarget(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleVecInput TargetPosition {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xD66164FC554C563B));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0xD66164FC1239396F));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0xD66164FCFB53C31E));
  }
  public IPerParticleFloatInput ScreenEdgeAlignmentDistance {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD66164FCDB3D3EAC));
  }


}