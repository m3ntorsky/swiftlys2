using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RampScalarSpline : CParticleFunctionOperator, IC_OP_RampScalarSpline {

  public C_OP_RampScalarSpline(nint handle) : base(handle) {
  }

  public C_OP_RampScalarSpline(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float RateMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ADFC178645AF561));
  }
  public ref float RateMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ADFC178566E670F));
  }
  public ref float StartTime_min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ADFC1785AC75BFB));
  }
  public ref float StartTime_max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ADFC17850B23185));
  }
  public ref float EndTime_min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ADFC1787B891932));
  }
  public ref float EndTime_max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ADFC1788575A138));
  }
  public ref float Bias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4ADFC178E7EF43B6));
  }
  public IParticleAttributeIndex_t Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4ADFC178C257B93B));
  }
  public ref bool ProportionalOp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4ADFC1780F8832BD));
  }
  public ref bool EaseOut {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4ADFC1788E58B9D1));
  }


}