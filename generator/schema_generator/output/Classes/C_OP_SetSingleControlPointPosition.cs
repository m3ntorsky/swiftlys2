using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetSingleControlPointPosition : CParticleFunctionPreEmission, IC_OP_SetSingleControlPointPosition {

  public C_OP_SetSingleControlPointPosition(nint handle) : base(handle) {
  }

  public ref bool SetOnce {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFE0B7A4D6B261086));
  }
  public ref int CP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xFE0B7A4DD4B1E579));
  }
  public IParticleCollectionVecInput CP1Pos {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xFE0B7A4D408288D9));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xFE0B7A4D3A9ED669));
  }


}