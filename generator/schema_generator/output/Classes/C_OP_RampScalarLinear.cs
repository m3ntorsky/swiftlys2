using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RampScalarLinear : CParticleFunctionOperator, IC_OP_RampScalarLinear {

  public C_OP_RampScalarLinear(nint handle) : base(handle) {
  }

  public ref float RateMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEE7E510C645AF561));
  }
  public ref float RateMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEE7E510C566E670F));
  }
  public ref float StartTime_min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEE7E510C5AC75BFB));
  }
  public ref float StartTime_max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEE7E510C50B23185));
  }
  public ref float EndTime_min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEE7E510C7B891932));
  }
  public ref float EndTime_max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEE7E510C8575A138));
  }
  public IParticleAttributeIndex_t Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xEE7E510CC257B93B));
  }
  public ref bool ProportionalOp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEE7E510C0F8832BD));
  }


}