using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_VectorNoise : CParticleFunctionOperator, IC_OP_VectorNoise {

  public C_OP_VectorNoise(nint handle) : base(handle) {
  }

  public C_OP_VectorNoise(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xEAAF071CE5729606));
  }
  public ref Vector OutputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xEAAF071C2EFED678));
  }
  public ref Vector OutputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xEAAF071C451280D2));
  }
  public ref float Fl4NoiseScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEAAF071CF340DAD9));
  }
  public ref bool Additive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEAAF071C0FA86105));
  }
  public ref bool Offset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEAAF071C17412B2A));
  }
  public ref float NoiseAnimationTimeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEAAF071C504CBE30));
  }


}