using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetFloatCollection : CParticleFunctionOperator, IC_OP_SetFloatCollection {

  public C_OP_SetFloatCollection(nint handle) : base(handle) {
  }

  public C_OP_SetFloatCollection(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput InputValue {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x72EFBE1734445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x72EFBE17324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x72EFBE17FB53C31E));
  }
  public IParticleCollectionFloatInput Lerp {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x72EFBE175C17F8E8));
  }


}