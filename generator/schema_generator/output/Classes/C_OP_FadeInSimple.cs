using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_FadeInSimple : CParticleFunctionOperator, IC_OP_FadeInSimple {

  public C_OP_FadeInSimple(nint handle) : base(handle) {
  }

  public ref float FadeInTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x31D1B5A1F0255B3));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x31D1B5AE5729606));
  }


}