using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapCPtoScalar : CParticleFunctionOperator, IC_OP_RemapCPtoScalar {

  public C_OP_RemapCPtoScalar(nint handle) : base(handle) {
  }

  public ref int CPInput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD9758CB0FB805736));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD9758CB0E5729606));
  }
  public ref int Field {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD9758CB0C257B93B));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9758CB0E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9758CB0D6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9758CB05F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9758CB051A0E8C4));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9758CB067FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9758CB02041DF9D));
  }
  public ref float InterpRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9758CB0D3B705A7));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0xD9758CB0FB53C31E));
  }


}