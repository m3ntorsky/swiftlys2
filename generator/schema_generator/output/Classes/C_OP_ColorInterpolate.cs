using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ColorInterpolate : CParticleFunctionOperator, IC_OP_ColorInterpolate {

  public C_OP_ColorInterpolate(nint handle) : base(handle) {
  }

  public C_OP_ColorInterpolate(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Color ColorFade {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x2F5E97470841572E));
  }
  public ref float FadeStartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2F5E974786B28BFA));
  }
  public ref float FadeEndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2F5E974700D5CA4F));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2F5E9747E5729606));
  }
  public ref bool EaseInOut {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2F5E97475172CF48));
  }


}