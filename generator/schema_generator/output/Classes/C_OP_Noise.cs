using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_Noise : CParticleFunctionOperator, IC_OP_Noise {

  public C_OP_Noise(nint handle) : base(handle) {
  }

  public C_OP_Noise(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x1F035961E5729606));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1F0359615F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1F03596151A0E8C4));
  }
  public ref float Fl4NoiseScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1F035961F340DAD9));
  }
  public ref bool Additive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1F0359610FA86105));
  }
  public ref float NoiseAnimationTimeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1F035961504CBE30));
  }


}