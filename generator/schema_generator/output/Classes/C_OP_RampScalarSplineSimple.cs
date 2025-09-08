using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RampScalarSplineSimple : CParticleFunctionOperator, IC_OP_RampScalarSplineSimple {

  public C_OP_RampScalarSplineSimple(nint handle) : base(handle) {
  }

  public ref float Rate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8BA5EF2EC3280E7));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8BA5EF267FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA8BA5EF22041DF9D));
  }
  public IParticleAttributeIndex_t Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA8BA5EF2C257B93B));
  }
  public ref bool EaseOut {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8BA5EF28E58B9D1));
  }


}