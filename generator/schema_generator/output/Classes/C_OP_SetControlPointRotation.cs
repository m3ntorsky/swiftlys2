using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointRotation : CParticleFunctionPreEmission, IC_OP_SetControlPointRotation {

  public C_OP_SetControlPointRotation(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointRotation(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionVecInput RotAxis {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x8F20B2F891872163));
  }
  public IParticleCollectionFloatInput RotRate {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x8F20B2F86747B556));
  }
  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8F20B2F8EB661472));
  }
  public ref int LocalCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8F20B2F8ACAAFF8F));
  }


}