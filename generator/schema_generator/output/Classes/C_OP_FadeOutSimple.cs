using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_FadeOutSimple : CParticleFunctionOperator, IC_OP_FadeOutSimple {

  public C_OP_FadeOutSimple(nint handle) : base(handle) {
  }

  public C_OP_FadeOutSimple(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FadeOutTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD439658FE86D2FC2));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD439658FE5729606));
  }


}