using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RampScalarLinearSimple : CParticleFunctionOperator, IC_OP_RampScalarLinearSimple {

  public C_OP_RampScalarLinearSimple(nint handle) : base(handle) {
  }

  public C_OP_RampScalarLinearSimple(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Rate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCD04073EEC3280E7));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCD04073E67FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCD04073E2041DF9D));
  }
  public IParticleAttributeIndex_t Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xCD04073EC257B93B));
  }


}