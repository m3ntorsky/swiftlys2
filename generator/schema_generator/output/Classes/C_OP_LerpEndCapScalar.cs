using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LerpEndCapScalar : CParticleFunctionOperator, IC_OP_LerpEndCapScalar {

  public C_OP_LerpEndCapScalar(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x308CB6FE5729606));
  }
  public ref float Output {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x308CB6F368F96A2));
  }
  public ref float LerpTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x308CB6F54FD987F));
  }


}