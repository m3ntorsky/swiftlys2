using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ReinitializeScalarEndCap : CParticleFunctionOperator, IC_OP_ReinitializeScalarEndCap {

  public C_OP_ReinitializeScalarEndCap(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xC52E8D41E5729606));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC52E8D415F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC52E8D4151A0E8C4));
  }


}