using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitFloatCollection : CParticleFunctionInitializer, IC_INIT_InitFloatCollection {

  public C_INIT_InitFloatCollection(nint handle) : base(handle) {
  }

  public C_INIT_InitFloatCollection(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput InputValue {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x70773EFA34445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x70773EFA324F6F74));
  }


}