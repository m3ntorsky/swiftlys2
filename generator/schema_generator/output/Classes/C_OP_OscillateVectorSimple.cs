using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_OscillateVectorSimple : CParticleFunctionOperator, IC_OP_OscillateVectorSimple {

  public C_OP_OscillateVectorSimple(nint handle) : base(handle) {
  }

  public ref Vector Rate {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB4CA468EC3280E7));
  }
  public ref Vector Frequency {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB4CA468BCCAA981));
  }
  public IParticleAttributeIndex_t Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xB4CA468C257B93B));
  }
  public ref float OscMult {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB4CA46816278E94));
  }
  public ref float OscAdd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB4CA4687B38A63D));
  }
  public ref bool Offset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB4CA46817412B2A));
  }


}