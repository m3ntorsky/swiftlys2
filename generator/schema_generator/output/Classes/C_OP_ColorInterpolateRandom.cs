using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ColorInterpolateRandom : CParticleFunctionOperator, IC_OP_ColorInterpolateRandom {

  public C_OP_ColorInterpolateRandom(nint handle) : base(handle) {
  }

  public C_OP_ColorInterpolateRandom(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Color ColorFadeMin {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x6185EEC8EFCBE55A));
  }
  public ref Color ColorFadeMax {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x6185EEC8D9DF4A70));
  }
  public ref float FadeStartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6185EEC886B28BFA));
  }
  public ref float FadeEndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6185EEC800D5CA4F));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x6185EEC8E5729606));
  }
  public ref bool EaseInOut {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6185EEC85172CF48));
  }


}