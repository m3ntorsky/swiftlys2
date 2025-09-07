using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MovementRotateParticleAroundAxis : CParticleFunctionOperator, IC_OP_MovementRotateParticleAroundAxis {

  public C_OP_MovementRotateParticleAroundAxis(nint handle) : base(handle) {
  }

  public C_OP_MovementRotateParticleAroundAxis(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionVecInput RotAxis {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x44C1E1F191872163));
  }
  public IParticleCollectionFloatInput RotRate {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x44C1E1F16747B556));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x44C1E1F1B3FDC289));
  }
  public ref bool LocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x44C1E1F162418E6E));
  }


}