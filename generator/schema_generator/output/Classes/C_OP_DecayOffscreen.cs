using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DecayOffscreen : CParticleFunctionOperator, IC_OP_DecayOffscreen {

  public C_OP_DecayOffscreen(nint handle) : base(handle) {
  }

  public IParticleCollectionFloatInput OffscreenTime {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA253F9AEB096E1F1));
  }


}