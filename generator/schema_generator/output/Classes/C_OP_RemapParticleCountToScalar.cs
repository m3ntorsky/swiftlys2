using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapParticleCountToScalar : CParticleFunctionOperator, IC_OP_RemapParticleCountToScalar {

  public C_OP_RemapParticleCountToScalar(nint handle) : base(handle) {
  }

  public C_OP_RemapParticleCountToScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4DE6C52E5729606));
  }
  public IParticleCollectionFloatInput InputMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x4DE6C5285E92181));
  }
  public IParticleCollectionFloatInput InputMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x4DE6C5277FE262F));
  }
  public IParticleCollectionFloatInput OutputMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x4DE6C525F8D7716));
  }
  public IParticleCollectionFloatInput OutputMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x4DE6C5251A0E8C4));
  }
  public ref bool ActiveRange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4DE6C523FA53B84));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x4DE6C52FB53C31E));
  }


}