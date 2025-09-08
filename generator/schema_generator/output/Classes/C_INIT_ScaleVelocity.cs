using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_ScaleVelocity : CParticleFunctionInitializer, IC_INIT_ScaleVelocity {

  public C_INIT_ScaleVelocity(nint handle) : base(handle) {
  }

  public IParticleCollectionVecInput Scale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xF226CCC35F596B51));
  }


}