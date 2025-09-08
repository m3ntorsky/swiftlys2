using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DecayClampCount : CParticleFunctionOperator, IC_OP_DecayClampCount {

  public C_OP_DecayClampCount(nint handle) : base(handle) {
  }

  public IParticleCollectionFloatInput Count {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xBBD38E0B7D31AC08));
  }


}