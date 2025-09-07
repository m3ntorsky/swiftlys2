using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitVecCollection : CParticleFunctionInitializer, IC_INIT_InitVecCollection {

  public C_INIT_InitVecCollection(nint handle) : base(handle) {
  }

  public C_INIT_InitVecCollection(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionVecInput InputValue {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x2F5AD47234445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2F5AD472324F6F74));
  }


}