using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapCPtoVector : CParticleFunctionOperator, IC_OP_RemapCPtoVector {

  public C_OP_RemapCPtoVector(nint handle) : base(handle) {
  }

  public ref int CPInput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA5B6B7CBFB805736));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA5B6B7CBE5729606));
  }
  public ref int LocalSpaceCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA5B6B7CBC8E9CB31));
  }
  public ref Vector InputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA5B6B7CB367FBCC9));
  }
  public ref Vector InputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA5B6B7CB286C1F07));
  }
  public ref Vector OutputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA5B6B7CBA04D6C7C));
  }
  public ref Vector OutputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA5B6B7CB8E39C86E));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA5B6B7CB67FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA5B6B7CB2041DF9D));
  }
  public ref float InterpRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA5B6B7CBD3B705A7));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0xA5B6B7CBFB53C31E));
  }
  public ref bool Offset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA5B6B7CB17412B2A));
  }
  public ref bool Accelerate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA5B6B7CBA9BEFF50));
  }


}